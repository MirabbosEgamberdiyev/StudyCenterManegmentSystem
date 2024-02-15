
using Domain.Entities.CRM;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class GuruhReporitory : Reporitory<Guruh>, IGuruhInterface
{
    public GuruhReporitory(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
