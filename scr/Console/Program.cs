using BPascal.LessonEx2.ClassDomain;

internal class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle("ouch");
        string license=vehicle.LicensePlate;

        Console.WriteLine(license);
            Vehicle vehicle = new Vehicle("abc", -1, 50, 75);
            Console.WriteLine(vehicle1.LicensePlate);
            Console.WriteLine(vehicle1.OdometerKm);
            Console.WriteLine(vehicle1.DailyRate);
            Console.WriteLine(vehicle1.FuelLevelPercentage);
    }
}