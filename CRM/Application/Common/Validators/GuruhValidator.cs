using Domain.Entities.CRM;

namespace Application.Common.Validators;

public static class GuruhValidator
{
    public static bool IsValid(this Guruh guruh)
        => guruh != null &&
        !string.IsNullOrEmpty(guruh.GuruhName) &&
        !string.IsNullOrEmpty(guruh.Davomiyligi) &&
        guruh.Start > guruh.End &&
        guruh.FanId > 0 &&
        guruh.TeacherId > 0 &&
        guruh.XonaId > 0 ;
    public static bool IsExist(this Guruh guruh, List<Guruh> guruhs)
        => guruhs.Any(g => g.Id != guruh.Id &&
                           g.GuruhName == guruh.GuruhName &&
                           g.Davomiyligi == guruh.Davomiyligi &&
                           g.FanId == guruh.FanId &&
                           g.TeacherId == guruh.TeacherId &&
                           g.XonaId == guruh.XonaId &&
                           g.TalabaGuruhs == guruh.TalabaGuruhs && 
                           g.TalabaDavomats == guruh.TalabaDavomats &&
                           g.HaftaKunlari == guruh.HaftaKunlari && 
                           g.Start == guruh.Start &&
                           g.End == guruh.End );
}
