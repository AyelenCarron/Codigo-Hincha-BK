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

    public IUserRepository UserRepository
    {
        get
        {
            if (this.userRepository is null)
            {
                this.userRepository = new EFUserRepository(_context);
            }

            return this.userRepository;
        }
    }

private IPersonRepository? personRepository; 

    public IPersonRepository PersonRepository
    {
        get
        {
            if (this.personRepository is null)
            {
                this.personRepository = new EFPersonRepository(_context);
            }

            return this.personRepository;
        }
    }

private IBanRepository? banRepository; 

    public IBanRepository BanRepository
    {
        get
        {
            if (this.banRepository is null)
            {
                this.banRepository = new EFBanRepository(_context);
            }

            return this.banRepository;
        }
    }

private IUserRolRepository? userRolRepository; 

    public IUserRolRepository UserRolRepository
    {
        get
        {
            if (this.userRolRepository is null)
            {
                this.userRolRepository = new EFUserRolRepository(_context);
            }

            return this.userRolRepository;
        }
    }

private IFileRepository? fileRepository; 

    public IFileRepository FileRepository
    {
        get
        {
            if (this.fileRepository is null)
            {
                this.fileRepository = new EFFileRepository(_context);
            }

            return this.fileRepository;
        }
    }

private IImageRepository? imageRepository; 

    public IImageRepository ImageRepository
    {
        get
        {
            if (this.imageRepository is null)
            {
                this.imageRepository = new EFImageRepository(_context);
            }

            return this.imageRepository;
        }
    }

private ICommentRepository? commentRepository; 

    public ICommentRepository CommentRepository
    {
        get
        {
            if (this.commentRepository is null)
            {
                this.commentRepository = new EFCommentRepository(_context);
            }

            return this.commentRepository;
        }
    }

private IPostRepository? postRepository; 

    public IPostRepository PostRepository
    {
        get
        {
            if (this.postRepository is null)
            {
                this.postRepository = new EFPostRepository(_context);
            }

            return this.postRepository;
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
