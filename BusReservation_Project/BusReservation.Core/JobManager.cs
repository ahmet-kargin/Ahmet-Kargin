using Newtonsoft.Json;
using System;

namespace BusReservation.Core
{
    public class JobManager
    {
        public static string MakeUrl(string url)
        {
            url = url.Replace("I", "i");
            url = url.Replace("İ", "i");
            url = url.Replace("ı", "i");

            url = url.ToLower();
            url = url.Replace("ö", "o");
            url = url.Replace("ğ", "g");
            url = url.Replace("ş", "s");
            url = url.Replace("ü", "u");
            url = url.Replace("ç", "c");

            url = url.Replace(" ", "-");
            url = url.Replace(".", "");

            return url;
        }

        public static string CreateMessage(string title,string message, string alertType)
        {
            var msg = new AlertMessage()
            {
                Title=title,
                Message=message,
                AlertType=alertType
            };
            return JsonConvert.SerializeObject(msg);
        }
    }
}
