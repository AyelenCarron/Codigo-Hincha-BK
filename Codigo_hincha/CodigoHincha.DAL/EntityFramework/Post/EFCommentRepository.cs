using CodigoHincha.DAL.EntityFramework;
using CodigoHincha.DAL.interfaces.Post;

namespace CodigoHincha.DAL.interfaces.Post;
public class EFCommentRepository : ICommentRepository
{
    private CodigoHinchaDbContext dbContext;
    
    public EFCommentRepository(CodigoHinchaDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
}