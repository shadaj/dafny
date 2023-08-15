﻿using Microsoft.Dafny.LanguageServer.Language;
using Microsoft.Dafny.LanguageServer.Language.Symbols;
using Microsoft.Dafny.LanguageServer.Workspace.ChangeProcessors;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OmniSharp.Extensions.LanguageServer.Server;
using System;
using Microsoft.Extensions.Options;

namespace Microsoft.Dafny.LanguageServer.Workspace {
  /// <summary>
  /// Extension methods to register the dafny workspace services to the language server implementation.
  /// </summary>
  public static class LanguageServerExtensions {
    /// <summary>
    /// Registers all services necessary to manage the dafny workspace.
    /// </summary>
    /// <param name="options">The language server where the workspace services should be registered to.</param>
    /// <param name="configuration">The configuration object holding the server configuration.</param>
    /// <returns>The language server enriched with the dafny workspace services.</returns>
    public static LanguageServerOptions WithDafnyWorkspace(this LanguageServerOptions options) {
      return options.WithServices(services => services.WithDafnyWorkspace());
    }

    private static IServiceCollection WithDafnyWorkspace(this IServiceCollection services) {
      return services
        .AddSingleton<IProjectDatabase, ProjectManagerDatabase>()
        .AddSingleton<CreateProjectManager>(provider => (boogieEngine, documentIdentifier) => new ProjectManager(
          provider.GetRequiredService<DafnyOptions>(),
          provider.GetRequiredService<ILogger<ProjectManager>>(),
          provider.GetRequiredService<CreateMigrator>(),
          provider.GetRequiredService<IFileSystem>(),
          provider.GetRequiredService<INotificationPublisher>(),
          provider.GetRequiredService<IVerificationProgressReporter>(),
          provider.GetRequiredService<CreateCompilationManager>(),
          provider.GetRequiredService<CreateIdeStateObserver>(),
          boogieEngine,
          documentIdentifier))
        .AddSingleton<IFileSystem, LanguageServerFilesystem>()
        .AddSingleton<IDafnyParser>(serviceProvider => {
          var options = serviceProvider.GetRequiredService<DafnyOptions>();
          return new DafnyLangParser(options,
            serviceProvider.GetRequiredService<IFileSystem>(),
            serviceProvider.GetRequiredService<ITelemetryPublisher>(),
            serviceProvider.GetRequiredService<ILogger<DafnyLangParser>>(),
            serviceProvider.GetRequiredService<ILogger<CachingParser>>());
        })
        .AddSingleton<ITextDocumentLoader>(CreateTextDocumentLoader)
        .AddSingleton<INotificationPublisher, NotificationPublisher>()
        .AddSingleton<CreateMigrator>(provider => (changes, cancellationToken) => new Migrator(
          provider.GetRequiredService<ILogger<Migrator>>(),
          provider.GetRequiredService<ILogger<SignatureAndCompletionTable>>(),
          changes, cancellationToken))
        .AddSingleton<ISymbolGuesser, SymbolGuesser>()
        .AddSingleton<ICompilationStatusNotificationPublisher, CompilationStatusNotificationPublisher>()
        .AddSingleton<ITelemetryPublisher, TelemetryPublisher>();
    }

    public static TextDocumentLoader CreateTextDocumentLoader(IServiceProvider services) {
      return TextDocumentLoader.Create(
        services.GetRequiredService<IDafnyParser>(),
        services.GetRequiredService<ISymbolResolver>(),
        services.GetRequiredService<ISymbolTableFactory>(),
        services.GetRequiredService<IGhostStateDiagnosticCollector>(),
        services.GetRequiredService<ICompilationStatusNotificationPublisher>(),
        services.GetRequiredService<ILogger<ITextDocumentLoader>>()
      );
    }
  }
}
