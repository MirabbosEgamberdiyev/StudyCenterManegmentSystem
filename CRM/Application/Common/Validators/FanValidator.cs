using Domain.Entities.CRM;

namespace Application.Common.Validators;

public static class FanValidator
{
    public static bool IsValid(this Fan fan)
    {
        return fan != null &&
               !string.IsNullOrEmpty(fan.FanName) &&
               !string.IsNullOrEmpty(fan.FanDescription);
    }
    public static bool IsExist(this Fan fan, List<Fan> fans)
    {
        return fans.Any(f =>
            f.FanName == fan.FanName &&
            f.FanDescription == fan.FanDescription &&
            f.Id != fan.Id &&
            Enumerable.SequenceEqual(f.TeacherFans ?? Enumerable.Empty<TeacherFan>(),
            fan.TeacherFans ?? Enumerable.Empty<TeacherFan>())

        );
    }
}
