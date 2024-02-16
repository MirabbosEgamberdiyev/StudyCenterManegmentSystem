using Domain.Entities.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Validators
{
    public static  class TalabaTolovValidator
    {
        public static bool IsValid(this TalabaTolov talabaTolov)
            => talabaTolov != null &&
            talabaTolov.GuruhId > 0 &&
            talabaTolov.TalabaId > 0 &&
            talabaTolov.QachonTolagan <= DateTime.Now &&
            talabaTolov.QanchaTolagan >= 0;

        public static bool IsExist(this TalabaTolov talabaTolov, List<TalabaTolov> talabaTolovs)
            => talabaTolovs.Any(t => t.QachonTolagan == talabaTolov.QachonTolagan &&
                                     t.QanchaTolagan == talabaTolov.QanchaTolagan &&
                                     t.TalabaId == talabaTolov.TalabaId &&
                                     t.GuruhId == talabaTolov.GuruhId &&
                                     t.TolovTuri == talabaTolov.TolovTuri &&
                                     t.Id != talabaTolov.Id
            );
           
    }
}
