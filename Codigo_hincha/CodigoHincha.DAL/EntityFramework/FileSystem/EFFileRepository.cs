using CodigoHincha.DAL.EntityFramework;
using CodigoHincha.DAL.interfaces.FileSystem;

namespace CodigoHincha.DAL.interfaces.FileSystem;
public class EFFileRepository : IFileRepository
{
    
    private CodigoHinchaDbContext dbContext;
    
    public EFFileRepository(CodigoHinchaDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
}