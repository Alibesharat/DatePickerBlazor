using System;
using System.Globalization;

namespace Microsoft.AspNetCore.Components
{
    public class PersianDateTimeBindConvertor
    {
        public static bool TryPresianConvertToDateTime(string Date, out DateTime value, out string ErrorMessage)
        {
            try
            {
                var PersianDate = Date.Split("/");
                PersianCalendar pc = new PersianCalendar();
                CultureInfo.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
                DateTime dt = new DateTime(int.Parse(PersianDate[0]), int.Parse(PersianDate[1]), int.Parse(PersianDate[2]), pc);
                value = dt;
                ErrorMessage = "";
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                value = default;
                return false; ;
            }

        }

    }
}
