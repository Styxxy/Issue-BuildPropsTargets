# Issue-BuildPropsTargets
Repository to simulate problem with Directory.Build.props and targets when using legacy project format

Logged issue on https://github.com/Microsoft/msbuild/issues/3874 .

# Description
When having a Directory.Build.props and/or Directory.Build.targets file, where you include a `<PackageReference />` these files are also included (by MSBuild, also Visual Studio) for legacy based project files (non-sdk format project files). This is great, except that when you set a condition on the `<PackageReference />` or it's `<ItemGroup>`, even if the condition would evaluate to `false` (and thus it should be skipped), the package is still included in the project. This doesn't happen for an SDK based project.

# Reproducable sample repository
https://github.com/Styxxy/Issue-BuildPropsTargets

# Environment details

## msbuild /version
```cmd
C:\Users\Styxxy>msbuild /version
Microsoft (R) Build Engine version 15.8.169+g1ccb72aefa for .NET Framework
Copyright (C) Microsoft Corporation. All rights reserved.

15.8.169.51996
```

## dotnet --info
```cmd
C:\Users\Styxxy>dotnet --info
.NET Core SDK (reflecting any global.json):
 Version:   2.1.402
 Commit:    3599f217f4

Runtime Environment:
 OS Name:     Windows
 OS Version:  10.0.17134
 OS Platform: Windows
 RID:         win10-x64
 Base Path:   C:\Program Files\dotnet\sdk\2.1.402\

Host (useful for support):
  Version: 2.1.4
  Commit:  85255dde3e

.NET Core SDKs installed:
  1.0.4 [C:\Program Files\dotnet\sdk]
  1.1.0 [C:\Program Files\dotnet\sdk]
  2.0.3 [C:\Program Files\dotnet\sdk]
  2.1.2 [C:\Program Files\dotnet\sdk]
  2.1.4 [C:\Program Files\dotnet\sdk]
  2.1.201 [C:\Program Files\dotnet\sdk]
  2.1.202 [C:\Program Files\dotnet\sdk]
  2.1.302 [C:\Program Files\dotnet\sdk]
  2.1.400 [C:\Program Files\dotnet\sdk]
  2.1.401 [C:\Program Files\dotnet\sdk]
  2.1.402 [C:\Program Files\dotnet\sdk]

.NET Core runtimes installed:
  Microsoft.AspNetCore.All 2.1.2 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.All]
  Microsoft.AspNetCore.All 2.1.4 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.All]
  Microsoft.AspNetCore.App 2.1.2 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.AspNetCore.App 2.1.4 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.NETCore.App 1.0.5 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 1.1.2 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 2.0.3 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 2.0.5 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 2.0.7 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 2.0.9 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 2.1.2 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 2.1.3-servicing-26724-03 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 2.1.4 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  ```
  
 ## Visual Studio 2017
 
Microsoft Visual Studio Community 2017 
Version 15.8.7
VisualStudio.15.Release/15.8.7+28010.2046
Microsoft .NET Framework
Version 4.7.03056

Installed Version: Community
