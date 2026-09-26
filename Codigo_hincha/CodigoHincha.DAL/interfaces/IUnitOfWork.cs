namespace CodigoHincha.DAL.interfaces;

public interface IUnitOfWork : IDisposable
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    IUserRepository UserRepository { get;}
    IPersonRepository PersonRepository { get;}
    IBanRepository BanRepository { get;}
    IUserRolRepositoty UserRolRepositoty { get;}
    IFileRepositoty FileRepositoty { get;}
    IImageRepositoty ImageRepositoty { get;}
    ICommentRepositoty CommentRepositoty { get;}
    IPostRepositoty PostRepositoty { get;}
}
