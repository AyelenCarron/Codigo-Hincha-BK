using CodigoHincha.DAL.EntityFramework;
using CodigoHincha.DAL.interfaces.Post;

namespace CodigoHincha.DAL.interfaces.Post;
public class EFPostRepository : IPostRepository
{
    private CodigoHinchaDbContext dbContext;
    
    public EFPostRepository(CodigoHinchaDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
}