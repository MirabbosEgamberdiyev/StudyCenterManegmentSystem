

using Domain.Entities.CRM;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class TeacherFanReporitory : Reporitory<TeacherFan>, ITeacherFanInterface
{
    public TeacherFanReporitory(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
