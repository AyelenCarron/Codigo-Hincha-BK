using CodigoHincha.DAL.EntityFramework;
using CodigoHincha.DAL.interfaces.FileSystem;

namespace CodigoHincha.DAL.interfaces.FileSystem;
public class EFImageRepository :IImageRepository
{
    
    private CodigoHinchaDbContext dbContext;
    
    public EFImageRepository(CodigoHinchaDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
}