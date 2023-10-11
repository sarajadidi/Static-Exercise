namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(86); //30
            var fahrenheit = TempConverter.CelsiusToFarenheit(30);//86

            Console.WriteLine($"celcius = {celcius}");
            Console.WriteLine($"fahrenheit = {fahrenheit}");

        }
    }
}
