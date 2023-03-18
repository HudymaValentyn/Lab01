using System;
using System.Reflection.Metadata;

namespace ConsoleApp2
{
    public class Program
    {

        static public double CalculatePerimeter(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double perimeter = a + b + c;
            Console.WriteLine("P: " + perimeter);
            return perimeter;
        }

        static public double CalculateArea(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double halfPerimeter = (a + b + c) / 2;
            // Використовуємо формулу Герона
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            Console.WriteLine("S: " + area);
            return area;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введiть першу вершину");
            Console.WriteLine("x1: ");
            string S1x = Console.ReadLine();
            int x1 = int.Parse(S1x);
            Console.WriteLine("y1: ");
            string S1y = Console.ReadLine();
            int y1 = int.Parse(S1y);

            Console.WriteLine("Введiть другу вершину");
            Console.WriteLine("x2: ");
            string S2x = Console.ReadLine();
            int x2 = int.Parse(S2x);
            Console.WriteLine("y2: ");
            string S2y = Console.ReadLine();
            int y2 = int.Parse(S2y);

            Console.WriteLine("Введiть третю вершину");
            Console.WriteLine("x3: ");
            string S3x = Console.ReadLine();
            int x3 = int.Parse(S3x);
            Console.WriteLine("y3: ");
            string S3y = Console.ReadLine();
            int y3 = int.Parse(S3y);

            CalculatePerimeter(x1, y1, x2, y2, x3, y3);
            CalculateArea(x1, y1, x2, y2, x3, y3);
            Console.ReadLine();

        }
    }
}