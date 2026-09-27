using CodigoHincha.DAL.interfaces;









namespace CodigoHincha.DAL.EntityFramework;

public class EFUnitOfWork(CodigoHinchaDbContext context) : IUnitOfWork
{
    private readonly CodigoHinchaDbContext _context = context;

    public IUserRepository UserRepository => throw new NotImplementedException();

    public IPersonRepository PersonRepository => throw new NotImplementedException();

    public IBanRepository BanRepository => throw new NotImplementedException();

    public IUserRolRepositoty UserRolRepositoty => throw new NotImplementedException();

    public IFileRepositoty FileRepositoty => throw new NotImplementedException();

    public IImageRepositoty ImageRepositoty => throw new NotImplementedException();

    public ICommentRepositoty CommentRepositoty => throw new NotImplementedException();

    public IPostRepositoty PostRepositoty => throw new NotImplementedException();

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return _context.SaveChangesAsync(cancellationToken);
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
