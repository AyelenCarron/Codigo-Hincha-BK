using CodigoHincha.DAL.EntityFramework;
using CodigoHincha.DAL.interfaces.Social;

namespace CodigoHincha.DAL.interfaces.Social;
public class EFReactionRepository : IReactionRepository
{
    private CodigoHinchaDbContext dbContext;
    
    public EFReactionRepository(CodigoHinchaDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
}