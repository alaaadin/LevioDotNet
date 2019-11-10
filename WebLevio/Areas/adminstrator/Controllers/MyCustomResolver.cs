using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLevio.Areas.adminstrator.Controllers
{
    public static class MyCustomResolver
    {
        [System.Data.Entity.DbFunction("Edm", "AddMinutes")]
        public static DateTime? AddMinutes(DateTime? timeValue, int addValue)
        {
            return timeValue?.AddMinutes(addValue);
        }

        [System.Data.Entity.DbFunction("Edm", "DiffDays")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "dateValue1")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "dateValue2")]
        public static int? DiffDays(Nullable<DateTime> dateValue1, Nullable<DateTime> dateValue2)
        {
            return (dateValue1?.Day - dateValue2?.Day);
        }
    }
}