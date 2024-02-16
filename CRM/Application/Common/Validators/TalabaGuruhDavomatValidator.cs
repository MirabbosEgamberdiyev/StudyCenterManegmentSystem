using Domain.Entities.CRM;

namespace Application.Common.Validators;

public static class TalabaGuruhDavomatValidator
{
    public static bool IsValid(this TalabaGuruhDavomat talabaGuruhDavomat)
        => talabaGuruhDavomat != null &&
        talabaGuruhDavomat.GuruhId > 0 &&
        talabaGuruhDavomat.TalabaId > 0 &&
        talabaGuruhDavomat.Qachon <= DateTime.Now;

    public static bool IsExist(this TalabaGuruhDavomat talabaGuruhDavomat,
                               List<TalabaGuruhDavomat> talabaGuruhDavomats)
        => talabaGuruhDavomats.Any(t =>  t.KeldiKemadi == talabaGuruhDavomat.KeldiKemadi &&
                                         t.TalabaId == talabaGuruhDavomat.TalabaId &&
                                         t.GuruhId == talabaGuruhDavomat.GuruhId &&
                                         t.Id != talabaGuruhDavomat.Id);
}
