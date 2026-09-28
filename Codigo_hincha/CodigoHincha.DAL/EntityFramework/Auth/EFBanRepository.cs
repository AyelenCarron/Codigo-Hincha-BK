using CodigoHincha.DAL.EntityFramework;
using CodigoHincha.DAL.interfaces.Auth;

namespace CodigoHincha.DAL.interfaces.Auth;
public class EFBanRepository : IBanRepository
{
    private  CodigoHinchaDbContext dbContext;
    
    public EFBanRepository(CodigoHinchaDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

}