using CodigoHincha.DAL.EntityFramework;
using CodigoHincha.DAL.interfaces.Social;

namespace CodigoHincha.DAL.interfaces.Social;
public class EFFollowRepository : IFollowRepository
{
    private CodigoHinchaDbContext dbContext;
    
    public EFFollowRepository(CodigoHinchaDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
}