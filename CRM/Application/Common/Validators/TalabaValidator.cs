using Domain.Entities.CRM;

namespace Application.Common.Validators;

public static class TalabaValidator
{
    public static bool IsValid(this Talaba talaba)
        => talaba != null &&
        !string.IsNullOrEmpty(talaba.FirstName) &&
        !string.IsNullOrEmpty(talaba.LastName) &&
        !string.IsNullOrEmpty(talaba.PhoneNumber);
    public static bool IsExist(this Talaba talaba, List<Talaba> talabas)
        => talabas.Any(t => t.FirstName == talaba.FirstName &&
        t.LastName == talaba.LastName &&
        t.PhoneNumber == talaba.PhoneNumber &&
        t.TalabaGuruhDavomats == talaba.TalabaGuruhDavomats &&
        t.TalabaGuruhs == talaba.TalabaGuruhs &&
        t.TalabaTolov == talaba.TalabaTolov
        );
        
}
