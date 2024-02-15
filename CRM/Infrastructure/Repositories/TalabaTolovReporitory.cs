using Domain.Entities.CRM;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class TalabaTolovReporitory : Reporitory<TalabaTolov>, ITalabaTolovInterface
{
    public TalabaTolovReporitory(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
