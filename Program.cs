namespace ChangingTempSysApp;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("--Exchanging Temperature System--");
            Console.WriteLine("1.Exchange from Celsius to Fareheit");
            Console.WriteLine("2.Exchange from Celsius to Celsius");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Enter your choice: ");
            int choice;
            double celsius;
            double fahrenheit;
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the temperature in Celsius to exchange into Celsius:");
                    double.TryParse(Console.ReadLine(),out celsius);
                    Console.WriteLine($"{celsius} C equals {CelsiusToFahrenheit(celsius)} F");
                    break;
                case 2:
                Console.WriteLine("Enter the temperature in Farenheit to exchange into Celsius:");
                    double.TryParse(Console.ReadLine(),out fahrenheit);
                    Console.WriteLine($"{fahrenheit} F equals {FahrenheitToCelsius(fahrenheit)} C");
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
        while (true);
    }
    public static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (9.0 / 5) * celsius + 32;
        return fahrenheit;
    }
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (5.0 / 9) * (fahrenheit - 32);
        return celsius;
    }
}
