namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

           var farenheit =  TempConverter.FahrenheitToCelsius(85);

            Console.WriteLine($"Here is your Farenheit : {farenheit}");

             var celcius = TempConverter.CelciusToFahrenheit(67.22);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($" here is your Celcius : {celcius}");
                

        }
    }
}
