using L2_23;

class Program
{
    static void Main()
    {
    
    double x1 = LineSegment.GetValid("Координаты первого отрезка. Х: ");
    double y1 = LineSegment.GetValid("Координаты первого отрезка. Y: ");
    
    if (x1 > y1)
    {
        double swapTemp = x1;
        x1 = y1;
        y1 = swapTemp;
    }
    
    double x2 = LineSegment.GetValid("Координаты второго отрезка. Х: ");
    double y2 = LineSegment.GetValid("Координаты второго отрезка. Y: ");
    
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
    
    int deltaX = LineSegment.GetValid("Введите значение, на которое уменьшается координата Х: ");
    LineSegment segment4 = segment1 - deltaX;
    Console.WriteLine($"После уменьшения X на {deltaX} -> {segment4.ToString()}");
    
    int deltaY = LineSegment.GetValid("Введите значение, на которое уменьшается координата Y: ");
    LineSegment segment5 = deltaY - segment1;
    Console.WriteLine($"После уменьшения Y на {deltaY} -> {segment5.ToString()}");
    }
}
