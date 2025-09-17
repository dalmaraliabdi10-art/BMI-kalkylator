class Program
{
    static void Main()
    {
        double bmi1 = CalculateBMI(70, 1.75);
        Console.WriteLine($"BMI (metric, default): {bmi1:F2}");

        double bmi2 = CalculateBMI(height: 1.80, weight: 85);
        Console.WriteLine($"BMI (metric, named args): {bmi2:F2}");

        double bmi3 = CalculateBMI(unit: "imperial", weight: 180, height: 70);
        Console.WriteLine($"BMI (imperial): {bmi3:F2}");
    }

    static double CalculateBMI(double weight, double height, string unit = "metric")
    {
        if (height <= 0) 
        {
            Console.WriteLine("Fel, längden måste vara > 0");
            return 0;
        }

        if (unit == "metric")
        {
            return weight / (height * height);
        }
        else if (unit == "imperial")
        {
            return 703 * (weight / (height * height));
        }
        else
        {
            Console.WriteLine("Okänd enhet, 0");
            return 0;
        }
    }
}
