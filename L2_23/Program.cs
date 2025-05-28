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
                double swapTemp = x1;
                x1 = y1;
                y1 = swapTemp;
            }

            Console.WriteLine("\nКоординаты второго отрезка: ");
            Console.Write("X: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            if (x2 > y2)
            {
                double swapTemp = x2;
                x2 = y2;
                y2 = swapTemp;
            }

            Console.WriteLine($"\n[{x1}, {y1}] [{x2}, {y2}]");
            LineSegment segment1 = new LineSegment(x1, y1);
            LineSegment segment2 = new LineSegment(x2, y2);

            Console.WriteLine((LineSegment.Intersects(segment1, segment2) ? "Отрезки пересекаются" : "Отрезки не пересекаются"));
            Console.WriteLine($"Длина отрезка [{x1}, {y1}] = {!segment1}");

            LineSegment segment3 = segment1;
            segment3++;
            Console.WriteLine($"Расширение отрезка [{x1}, {y1}] -> {segment3.ToString()}");

            Console.WriteLine($"Целая часть X: {(int)segment1}");
            Console.WriteLine($"Координата Y (double): {(double)segment1}");

            Console.Write("Введите значение, на которое уменьшается координата Х: ");
            int deltaX = Convert.ToInt32(Console.ReadLine());
            LineSegment segment4 = segment1 - deltaX;
            Console.WriteLine($"После уменьшения X на {deltaX} -> {segment4.ToString()}");

            Console.Write("Введите значение, на которое уменьшается координата Y: ");
            int deltaY = Convert.ToInt32(Console.ReadLine());
            LineSegment segment5 = deltaY - segment1;
            Console.WriteLine($"После уменьшения Y на {deltaY} -> {segment5.ToString()}");
        }

        catch
        {
            Console.WriteLine("Некорректный ввод");
        }
    }
}