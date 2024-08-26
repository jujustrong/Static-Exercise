namespace StaticExercise;

public static class TempConverter
{
    public static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }
    
    public static double CelsiustoFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }
}