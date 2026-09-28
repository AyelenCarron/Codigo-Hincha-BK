using CodigoHincha.DAL.interfaces.Auth;
using CodigoHincha.DAL.EntityFramework;

namespace CodigoHincha.DAL.EntityFramework.Auth;
public class EFUserRepository : IUserRepository
{
    private CodigoHinchaDbContext dbContext;
    
    public EFUserRepository(CodigoHinchaDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
}