using CodigoHincha.DAL.EntityFramework;
using CodigoHincha.DAL.interfaces.Auth;

namespace CodigoHincha.DAL.interfaces.Auth;
public class EFUserRolRepository : IUserRolRepository
{
    private CodigoHinchaDbContext dbContext;

    public EFUserRolRepository(CodigoHinchaDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
}