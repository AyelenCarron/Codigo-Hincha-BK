using CodigoHincha.DAL.EntityFramework;
using CodigoHincha.DAL.interfaces.Social;

namespace CodigoHincha.DAL.interfaces.Social;
public class EFClubRepository : IClubRepository
{
    private CodigoHinchaDbContext dbContext;
    
    public EFClubRepository(CodigoHinchaDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
}