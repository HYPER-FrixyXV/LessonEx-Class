using BPascal.LessonEx2.ClassDomain;

internal class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle();
        string license=vehicle.GetLicensePlate();

        Console.WriteLine(license);
    }
}