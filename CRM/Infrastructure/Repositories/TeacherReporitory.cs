

using Domain.Entities.CRM;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class TeacherReporitory : Reporitory<Teacher>, ITeacherInterface
{
    public TeacherReporitory(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
