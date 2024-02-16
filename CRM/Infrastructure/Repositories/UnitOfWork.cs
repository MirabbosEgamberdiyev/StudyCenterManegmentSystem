using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class UnitOfWork(ApplicationDbContext dbContext) : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public IFanInterface FanInterface => new FanReporitory(_dbContext);

    public IGuruhInterface GuruhInterface => new GuruhReporitory(_dbContext);

    public ITalabaGuruhDavomatInterface TalabaGuruhDavomatInterface => new TalabaGuruhDavomatReporitory(_dbContext);
    public ITalabaGuruhInterface TalabaGuruhInterface => new TalabaGuruhReporitory(_dbContext);

    public ITalabaInterface TalabaInterface => new TalabaReporitory(_dbContext);

    public ITalabaTolovInterface TalabaTolovInterface => new TalabaTolovReporitory(_dbContext);

    public IXonaInterface XonaInterface => new XonaReporitory(_dbContext);

    public void Dispose()
         => GC.SuppressFinalize(this);


    public async Task SaveChangeAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
