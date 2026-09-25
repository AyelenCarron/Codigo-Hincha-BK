using CodigoHincha.Domain.Auth;
using CodigoHincha.Domain.Post;

namespace CodigoHincha.Domain.Social;

public class Reaction
{
    private long idReaction;
    public long IdReaction { get => idReaction; set => idReaction = value; }

    private DateTime dateTime = DateTime.UtcNow;
    public DateTime DateTime { get => dateTime; set => dateTime = value; }

    private long idPost;
    public long IdPost { get => idPost; set => idPost = value; }

    private CodigoHincha.Domain.Post.Post? post = null;
    public virtual CodigoHincha.Domain.Post.Post? Post { get => post; set => post = value; }

    private long idUser;
    public long IdUser { get => idUser; set => idUser = value; }

    private User? user = null;
    public virtual User? User { get => user; set => user = value; }

    private bool isLike;

    public bool IsLike {get => isLike; set=> isLike =value; }
}