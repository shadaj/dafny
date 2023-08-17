#! /bin/bash
# Until we get proper dependency to previous Dafny, you have to generate the file GeneratedFromDafny.cs
# To remove this manual build process, when it will be appropriate:
# 1. Delete the file GeneratedFromDafny.cs
# 2. Add a dependcy to 
#      <PackageReference Include="dafny.msbuild" Version="1.0.0" />
# That's it! The same file will now be automatically generated as obj/Debug/net6.0/GeneratedFromDafny.cs
# 3. Remove the following dependencies that are being taken care by dafny-msbuild
#       <PackageReference Include="Microsoft.Build.Framework" Version="16.5.0" PrivateAssets="All" />
#       <PackageReference Include="Microsoft.Build.Utilities.Core" Version="16.5.0" PrivateAssets="All" />
#       <PackageReference Include="System.Linq.Parallel" Version="4.3.0" PrivateAssets="All" />

# If an argument is passed to the script, store it in this variable. Otherwise use the default "GeneratedFromDafny.cs"
# Something like output = if no arguments then  "GeneratedFromDafny.cs" else first argument

if [ "$#" != 0 ]; then
  output="$1"
else
  output="GeneratedFromDafny"
fi

../../Scripts/dafny translate cs --output $output.cs AST/Formatting.dfy
../../Scripts/dafny translate cs --output "${output}Rust.cs" Compilers/Rust/Dafny-compiler-rust.dfy
python3 -c "
import re
with open ('$output.cs', 'r' ) as f:
  content = f.read()
  content_new = re.sub('\\[assembly[\\s\\S]*?(?=namespace Formatting)|namespace\\s+\\w+\\s*\\{\\s*\\}\\s*//.*|_\\d_', '', content, flags = re.M)
with open('$output.cs', 'w') as w:
  w.write(content_new)

with open ('${output}Rust.cs', 'r' ) as f:
  content = f.read()
  content_new = re.sub('\\[assembly[\\s\\S]*?(?=namespace DAST)|namespace\\s+\\w+\\s*\\{\\s*\\}\\s*//.*|_\\d_', '', content, flags = re.M)
with open('${output}Rust.cs', 'w') as w:
  w.write(content_new)
"
dotnet tool run dotnet-format -w --include $output.cs ${output}Rust.cs
