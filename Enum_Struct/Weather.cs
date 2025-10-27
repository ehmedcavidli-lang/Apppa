using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Struct
{
    internal struct Weather
    {
        public string City;
        public double Temperature;
        public WeatherCondition Condition;


        public void HavaninSeraiti()
        {
            if (Temperature >= 25)
            {
                Condition = WeatherCondition.Sunny;
                Console.WriteLine("Hava istidir getdik denize");
            }
            else if (Temperature >= 15 && Temperature < 25)
            {
                Condition = WeatherCondition.Windy;
                Console.WriteLine("Hava kuleklidir evde qalaq");
            }
            else if (Temperature >= 5 && Temperature < 15)
            {
                Condition = WeatherCondition.Cloudy;
                Console.WriteLine("Hava buludludur ehtiyyatli ol");
            }
            else if (Temperature > 0 && Temperature < 5)
            {
                Condition = WeatherCondition.Rainy;
                Console.WriteLine("Hava yaqislidir cetir gotur");
            }
            else
            { Condition = WeatherCondition.Snowy;
                Console.WriteLine("Hava qarlidir qar-topu oynayaq");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{City} seheri {Temperature} tempratur {Condition} havanin veziyyeti");
        }
    }
}
