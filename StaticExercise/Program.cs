namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var temp1 = TempConverter.FahrenheitToCelsius(78);
            Console.WriteLine(Math.Floor(temp1));
            var temp2 = TempConverter.CelsiustoFahrenheit(20);
            Console.WriteLine(Math.Floor(temp2));
        }
    }
}
