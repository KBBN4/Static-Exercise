using System;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

           var farenheit =  TempConverter.FahrenheitToCelsius(32);

            Console.WriteLine($"Here is your Farenheit : {farenheit}");

             var celcius = TempConverter.CelciusToFahrenheit(0);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($" here is your Celcius : {celcius}");
                

        }
    }
}
