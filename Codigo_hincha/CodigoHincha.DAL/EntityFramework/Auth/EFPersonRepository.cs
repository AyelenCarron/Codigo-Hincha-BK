using CodigoHincha.DAL.EntityFramework;
using CodigoHincha.DAL.interfaces.Auth;

namespace CodigoHincha.DAL.interfaces.Auth;
public class EFPersonRepository : IPersonRepository
{
    private CodigoHinchaDbContext dbContext;

    public EFPersonRepository(CodigoHinchaDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    
}