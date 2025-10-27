using Enum_Struct;

Console.WriteLine("Seher  daxil edin: ");





string city = Console.ReadLine();


Console.Write("Temperaturu daxil edin: ");
string tempStr = Console.ReadLine();

double temp = Convert.ToDouble(tempStr);

Weather weather = new Weather
{
    City = city,
    Temperature = temp
};

weather.HavaninSeraiti();
weather.DisplayInfo();
