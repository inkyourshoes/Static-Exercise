using System;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine("After conversion:");
            Console.WriteLine($"celsius {celsius} ");
            Console.WriteLine($"fahrenheit {fahrenheit} ");
        }
    }
}
//public static class TempConverter
    //{
       // public static double FahrenheitToCelsius(double fahrenheit)
        //{
          // return (fahrenheit - 32) / 1.8;
        //}

        //public static double CelsiusToFahrenheit(double celsius)
       //{
        //   return (celsius * 9) / 5 + 32;
       //}
  // }
//}

        


