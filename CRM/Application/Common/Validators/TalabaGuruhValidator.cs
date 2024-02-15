using Domain.Entities.CRM;

namespace Application.Common.Validators;

public static class TalabaGuruhValidator
{
    public static bool IsValid(this TalabaGuruh talabaGuruh)
        => talabaGuruh != null &&
        talabaGuruh.GuruhId > 0 &&
        talabaGuruh.TalabaId > 0;
    public static bool IsExist(this TalabaGuruh talabaGuruh, List<TalabaGuruh> talabaGuruhs)
        => talabaGuruhs.Any(t => t.GuruhId == talabaGuruh.GuruhId &&
                                 t.TalabaId == talabaGuruh.TalabaId &&
                                 t.Talaba == talabaGuruh.Talaba &&
                                 t.Guruh == talabaGuruh.Guruh);
}
