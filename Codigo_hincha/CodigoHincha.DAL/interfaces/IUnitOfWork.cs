using CodigoHincha.DAL.interfaces.Auth;
using CodigoHincha.DAL.interfaces.FileSystem;
using CodigoHincha.DAL.interfaces.Post;

namespace CodigoHincha.DAL.interfaces;

public interface IUnitOfWork : IDisposable
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    IUserRepository UserRepository { get;}
    IPersonRepository PersonRepository { get;}
    IBanRepository BanRepository { get;}
    IUserRolRepository UserRolRepository { get;}
    IFileRepository FileRepository { get;}
    IImageRepository ImageRepository { get;}
    ICommentRepository CommentRepository { get;}
    IPostRepository PostRepository { get;}
}
