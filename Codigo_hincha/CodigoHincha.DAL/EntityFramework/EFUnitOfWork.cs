using CodigoHincha.DAL.EntityFramework.Auth;
using CodigoHincha.DAL.interfaces;
using CodigoHincha.DAL.interfaces.Auth;
using CodigoHincha.DAL.interfaces.FileSystem;
using CodigoHincha.DAL.interfaces.Post;

namespace CodigoHincha.DAL.EntityFramework;

public class EFUnitOfWork(CodigoHinchaDbContext context) : IUnitOfWork
{
    private readonly CodigoHinchaDbContext _context = context;

    private IUserRepository? userRepository; 

    public IUserRepository UserRepository;
    {
        get
        {
            if (this.userRepository is null)
            {
                this.userRepository = EFUserRepository()
            }
        }
    }

    public IPersonRepository PersonRepository => throw new NotImplementedException();

    public IBanRepository BanRepository => throw new NotImplementedException();

    public IUserRolRepository UserRolRepository => throw new NotImplementedException();

    public IFileRepository FileRepository => throw new NotImplementedException();

    public IImageRepository ImageRepository => throw new NotImplementedException();

    public ICommentRepository CommentRepository => throw new NotImplementedException();

    public IPostRepository PostRepository => throw new NotImplementedException();

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
