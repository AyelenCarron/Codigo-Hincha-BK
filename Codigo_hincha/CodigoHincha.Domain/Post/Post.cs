namespace CodigoHincha.Domain.Post;

public class Post
{
    private long id;
    private long Id{ get=> id; set => id = value; }

    private string body= String.Empty;
    public string Body { get => body; set => body = value; }

    private CodigoHincha.Domain.File.File? file;
    public virtual CodigoHincha.Domain.FileSystem.File? File { get => file; set => file = value; }

    private User? user;
    public  User? User { get => user; set => user = value; }
}