namespace Ejemplo.Domian.FileSystem;

public class File
{
    private long id;
    public global::System.Int64 Id { get => id; set => id = value; }

    private string fileName = string.Empty;
    public global::System.String FileName { get => fileName; set => fileName = value; }

    private string contenType = string.Empty;
    public global::System.String ContenType { get => contenType; set => contenType = value; }

    private string storagePath = string.Empty;
    public global::System.String StoragePath { get => storagePath; set => storagePath = value; }
}