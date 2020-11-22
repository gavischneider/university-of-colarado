using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an angle in degress: ");
            int angle = int.Parse(Console.ReadLine());
            double angleInRadians = angle * (float) Math.PI / 180 ;
            double sinAngle = Math.Sin(angleInRadians);
            double cosAngle = Math.Cos(angleInRadians);
            Console.WriteLine("Sin: " + sinAngle);
            Console.WriteLine("Cos: " + cosAngle);
        }
    }
}
