using System;
namespace Task1InternshipReiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Hours : ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Input Minutes : ");
            int minutes = int.Parse(Console.ReadLine());

            //Each hour on the clock represents an angle of 30 degrees (360 divided by 12)
            double HID = (hours * 30) + (minutes * 30.0 / 60);
            //each minute on the clock will represent an angle of 6 degrees (360 divided by 60)
            double MID = minutes * 6;

            double diff = Math.Abs(HID - MID);

            if (diff > 180)
            {
                diff = 360 - diff;
            }

            Console.WriteLine($"Angle is {diff} degrees");
            Console.ReadKey();
        }
    }
}