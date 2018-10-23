# Issue-BuildPropsTargets
Repository to simulate problem with Directory.Build.props and targets when using legacy project format

# Description
When having a Directory.Build.props and/or Directory.Build.targets file, where you include a `<PackageReference />` these files are also included (by MSBuild, also Visual Studio) for legacy based project files (non-sdk format project files). This is great, except that when you set a condition on the `<PackageReference />` or it's `<ItemGroup>`, even if the condition would evaluate to `false` (and thus it should be skipped), the package is still included in the project. This doesn't happen for an SDK based project.
