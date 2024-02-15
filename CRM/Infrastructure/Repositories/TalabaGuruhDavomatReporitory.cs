

using Domain.Entities.CRM;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class TalabaGuruhDavomatReporitory : Reporitory<TalabaGuruhDavomat>, ITalabaGuruhDavomatInterface
{
    public TalabaGuruhDavomatReporitory(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
