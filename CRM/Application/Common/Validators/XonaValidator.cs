using Domain.Entities.CRM;

namespace Application.Common.Validators;

public static class XonaValidator
{
    public static bool IsValid(this Xona xona)
        => xona != null &&
        string.IsNullOrEmpty(xona.XonaName) &&
        xona.Sigimi > 0 &&
        xona.Qavat > 0;
    public static bool IsExist(this Xona xona, IEnumerable<Xona> xonalar)
        => xonalar.Any(x => x.XonaName == xona.XonaName &&
                          x.Sigimi == xona.Sigimi &&
                          x.Qavat == xona.Qavat &&
                          x.Id != xona.Id);
}
