

using Domain.Entities.CRM;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class TalabaReporitory : Reporitory<Talaba>, ITalabaInterface
{
    public TalabaReporitory(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
