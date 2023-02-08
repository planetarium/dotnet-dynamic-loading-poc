# Subject

When the version of the interface project (i.e., Libplanet) changes, how it works.

# Command

```
dotnet run --project ./Runner__VersionChanged
```

# Result

It fails when a new version is recent more than the before version. It seems to trust semver versioning. If the original version was `0.45.0`, a new version cannot `0.44.1` but `0.46.0` can be.
