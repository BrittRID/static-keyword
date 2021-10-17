using System;

namespace Static_Keyword_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(10000);//20

            var fahrenheit = TempConverter.CelsiusToFahrenheit(5); //68


            Console.WriteLine("After Conversion");
            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
