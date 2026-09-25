namespace CodigoHincha.Domain.FileSystem;

public class File
{
    private long idFile;
    public long IdFile { get => idFile; set => idFile = value; }

    private string fileName = string.Empty;
    public string FileName { get => fileName; set => fileName = value; }

    private string contenType = string.Empty;
    public string ContenType { get => contenType; set => contenType = value; }

    private string storagePath = string.Empty;
    public string StoragePath { get => storagePath; set => storagePath = value; }
}