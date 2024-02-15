

using Domain.Entities.CRM;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class XonaReporitory : Reporitory<Xona>, IXonaInterface
{
    public XonaReporitory(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
