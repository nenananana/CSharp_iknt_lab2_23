using L2_23;
using System;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Координаты первого отрезка: ");
            Console.Write("X: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            if (x1 > y1)
            {
                double xy1 = x1;
                x1 = y1;
                y1 = xy1;
            }

            Console.WriteLine("\nКоординаты второго отрезка: ");
            Console.Write("X: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            if (x2 > y2)
            {
                double xy2 = x2;
                x2 = y2;
                y2 = xy2;
            }

            Console.WriteLine($"\n[{x1}, {y1}] [{x2}, {y2}]");

            LineSegment segment1 = new LineSegment(x1, y1);
            LineSegment segment2 = new LineSegment(x2, y2);

            Console.WriteLine((LineSegment.Intersects(segment1, segment2) ? "Отрезки пересекаются" : "Отрезки не пересекаются"));
            Console.WriteLine($"Длина отрезка [{x1}, {y1}] = {!segment1}");


            LineSegment segment3 = segment1;
            segment3++;
            Console.WriteLine($"Расширение отрезка [{x1}, {y1}] -> {segment3.ToString()}");

            // Неявное int
            Console.WriteLine($"Целая часть X: {(int)segment1}");
            // Явное double
            Console.WriteLine($"Координата Y (double): {(double)segment1}");

            Console.Write("Введите значение, на которое уменьшается координата Х: ");
            int bix = Convert.ToInt32(Console.ReadLine());
            LineSegment segment4 = segment1 - bix;
            Console.WriteLine($"После уменьшения X на {bix} -> {segment4.ToString()}");

            Console.Write("Введите значение, на которое уменьшается координата Y: ");
            int biy = Convert.ToInt32(Console.ReadLine());
            LineSegment segment5 = biy - segment1;
            Console.WriteLine($"После уменьшения Y на {biy} -> {segment5.ToString()}");
        }

        catch
        {
            Console.WriteLine("Некорректный ввод");
        }
    }
}