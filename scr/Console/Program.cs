using BPascal.LessonEx2.ClassDomain;

internal class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle1 = new Vehicle("abc", 5, 2, 2.5, 100);

        Console.WriteLine(vehicle1.LicensePlate);
        Console.WriteLine(vehicle1.Odometer);
        Console.WriteLine(vehicle1.DailyRate);
        Console.WriteLine(vehicle1.FuelLvPerc);
    }
}