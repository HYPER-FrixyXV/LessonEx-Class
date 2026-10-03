using BPascal.LessonEx2.ClassDomain;

internal class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle("ouch");
        string license=vehicle.LicensePlate;

        Console.WriteLine(license);
    }
}