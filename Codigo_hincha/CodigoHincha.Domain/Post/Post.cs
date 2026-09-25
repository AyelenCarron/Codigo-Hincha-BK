using CodigoHincha.Domain.Auth;
using CodigoHincha.Domain.FileSystem;

namespace CodigoHincha.Domain.Post;

public class Post
{
    private long idPost;
    public long IdPost { get => idPost; set => idPost = value; }

    private string body= String.Empty;
    public string Body { get => body; set => body = value; }

    private DateTime dateTime = DateTime.UtcNow;
    public DateTime DateTime { get => dateTime; set => dateTime = value; }

    private CodigoHincha.Domain.FileSystem.File? file;
    public virtual CodigoHincha.Domain.FileSystem.File? File { get => file; set => file = value; }

    private User? user;
    public  User? User { get => user; set => user = value; }
}