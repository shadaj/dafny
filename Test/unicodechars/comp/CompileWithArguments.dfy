// NONUNIFORM: Multiple testing scenarios, highly backend sensitive, testing CLI
// Note that C++ is not supported yet

// RUN: %dafny /compile:0 "%s" > "%t"
// RUN: %baredafny run %args --unicode-char --no-verify --target:cs "%s" Csharp 1 >> "%t"
// RUN: %baredafny run %args --unicode-char --no-verify --target:java "%s" -- Java --heya >> "%t"
// RUN: %baredafny run %args --unicode-char --no-verify --target:js "%s" -- Javascript 2 >> "%t"
// RUN: %dafny /noVerify /compile:4 /unicodeChar:1 /compileTarget:py "%s" --args Python 1 >> "%t"
// RUN: %dafny /noVerify /compile:4 /unicodeChar:1 /compileTarget:go "%s" --args "Go go" 1 >> "%t"
// RUN: %baredafny build %args --unicode-char --no-verify --target:cs "%s" --output:%s.dll
// RUN: dotnet %s.dll "dotnet" "howdy" >> "%t"
// RUN: dotnet %s.dll "dotnet" "hello" >> "%t"
// RUN: dotnet %s.dll "dotnet" "aloha" >> "%t"
// RUN: %baredafny build %args --unicode-char --no-verify --target:js "%s" --output=%s.js
// RUN: node %s.js "javascript" 2 >> "%t"
// RUN: node %s.js "javascript" 1 >> "%t"
// RUN: node %s.js "javascript" "aloha" >> "%t"
// RUN: %baredafny build %args --unicode-char --no-verify --target:java "%s" --output:"%s.jar" >> "%t"
// RUN: java -jar "%s.jar" Java 2 >> "%t"
// RUN: java -jar "%s.jar" Java 1 >> "%t"
// RUN: java -jar "%s.jar" Java aloha >> "%t"
// RUN: %baredafny build %args --unicode-char --no-verify --target:py "%s" >> "%t"
// RUN: python3 %S/CompileWithArguments-py Python 2 >> "%t"
// RUN: python3 %S/CompileWithArguments-py Python 1 >> "%t"
// RUN: python3 %S/CompileWithArguments-py Python aloha >> "%t"
// RUN: %baredafny build %args --unicode-char --no-verify --target:go "%s" >> "%t"
// RUN: env GO111MODULE=auto GOPATH=%S/CompileWithArguments-go go run %S/CompileWithArguments-go/src/CompileWithArguments.go Go 2 >> "%t"
// RUN: env GO111MODULE=auto GOPATH=%S/CompileWithArguments-go go run %S/CompileWithArguments-go/src/CompileWithArguments.go Go 1 >> "%t"
// RUN: env GO111MODULE=auto GOPATH=%S/CompileWithArguments-go go run %S/CompileWithArguments-go/src/CompileWithArguments.go Go aloha >> "%t"
// RUN: %diff "%s.expect" "%t"

method Main(args: seq<string>) {
  if |args| != 3 {
    print "Expected 3 arguments, got ", |args|;
  } else {
    print args[1], " says ";
    if args[2] == "1" {
      print "hello\n";
    } else if args[2] == "2" {
      print "howdy\n";
    } else {
      print args[2],"\n";
    }
  }
}
