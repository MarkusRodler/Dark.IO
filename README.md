# Dark.IO (Library)
![Library](https://github.com/MarkusRodler/Dark.IO/workflows/Library/badge.svg)

## How to use

### Async Delete
```csharp
    public static Task Delete(string path)
```

### Async WriteAllText (Creates all missing directories)
```csharp
    public static Task File.WriteAllText(string path, string? contents, CancellationToken cancellationToken = default)
```
