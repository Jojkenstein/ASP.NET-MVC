using System.Globalization;

namespace ASP.NET_MVC.Models
{
    public class DoctorModel
    {
        public static string CheckTemperature(string temperature, string scale)
        {
            //The follwing 3 lines of code is needed for the decimal-sign to be interpreted correctly. "using System.Globalization;" must be added as well!
            CultureInfo culture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            float temp = float.Parse(temperature);
            if (scale == "F")
            {
                temp = (temp - 32) * 5 / 9;
            }
            if (temp >= 38)
            {
                return "You have a fever.";
            }
            if (temp < 35)
            {
                return "You have hypothermia.";
            }
            else
            {
                return "You have neither fever nor hypothermia.";
            }
        }
    }
}
