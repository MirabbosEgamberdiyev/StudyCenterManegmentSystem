
using Domain.Entities.CRM;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class FanReporitory : Reporitory<Fan>, IFanInterface
{
    public FanReporitory(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
