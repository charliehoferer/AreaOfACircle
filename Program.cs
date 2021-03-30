using System;

namespace AreaOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle?");
            //var radius = double.Parse(Console.ReadLine());
            // var pi = Math.PI;

            // var areaofCircle = pi * (radius *radius)

            double realRadius;
            var radius = double.TryParse(Console.ReadLine(), out realRadius); 
            var areaOfCircle = CalculateArea(realRadius);

            Console.WriteLine($"The area of your circle with a radius of {realRadius} is {areaOfCircle}");
        }
         public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);
        }
        
            
        }
    }


