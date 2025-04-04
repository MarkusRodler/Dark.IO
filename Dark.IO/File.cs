namespace Dark.IO;

public static class File
{
    public static Task Delete(string path)
    {
        System.IO.File.Delete(path);
        return Task.CompletedTask;
    }

    public static Task WriteAllText(string path, string? contents, CancellationToken cancellationToken = default)
    {
        FileInfo file = new(path);
        file.Directory?.Create();
        return System.IO.File.WriteAllTextAsync(file.FullName, contents, cancellationToken);
    }
}
