namespace CodigoHincha.Domain.FileSystem;

public class Image : File
{
    private int width = 0;
    public int Width { get => width; set => width = value; }
    private int height = 0;
    public int Height { get => height; set => height = value; }

}