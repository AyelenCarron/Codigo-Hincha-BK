using CodigoHincha.Domain.Auth;

namespace CodigoHincha.Domain.Post;

public class Comment
{
    private long idComment;
    public long IdComment { get => idComment; set => idComment = value; }

    private long postId;
    public long PostId { get => postId; set => postId = value; }

    private Post? post = null;
    public virtual Post? Post { get => post; set => post = value; }

    private long userId;
    public long UserId { get => userId; set => userId = value; }

    private User? user = null;
    public virtual User? User { get => user; set => user = value; }

    private string text = "";
    public string Text { get => text; set => text = value; }

    private DateTime dateTime = DateTime.UtcNow;
    public DateTime DateTime { get => dateTime; set => dateTime = value; }

}