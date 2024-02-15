
using Domain.Entities.CRM;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class TalabaGuruhReporitory : Reporitory<TalabaGuruh>, ITalabaGuruhInterface
{
    public TalabaGuruhReporitory(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
