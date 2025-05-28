using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_23
{
    internal class LineSegment
    {
        double x;
        double y;

        public LineSegment(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // проверка пересечения отрезков
        public static bool Intersects(LineSegment segment1, LineSegment segment2)
        {
            return !(segment1.y < segment2.x || segment2.y < segment1.x);
        }

        // вычисление длины отрезка
        public static double operator !(LineSegment segment)
        {
            return Convert.ToDouble(Convert.ToDecimal(segment.y) - Convert.ToDecimal(segment.x));
        }

        // расширение отрезка на 1 вправо и влево
        public static LineSegment operator ++(LineSegment segment)
        {
            return new LineSegment(segment.x - 1, segment.y + 1);
        }

        // неявное к int
        public static implicit operator int(LineSegment segment)
        {
            return (int)segment.x;
        }

        // явное к double
        public static explicit operator double(LineSegment segment)
        {
            return segment.y;
        }

        // левосторонняя операция, уменьшается координата х
        public static LineSegment operator -(LineSegment segment, int value)
        {
            return new LineSegment(segment.x - value, segment.y);
        }

        // правосторонняя операция, уменьшается координата y
        public static LineSegment operator -(int value, LineSegment segment)
        {
            return new LineSegment(segment.x, segment.y - value);
        }

        public override string ToString()
        {
            return $"\n[{x}, {y}]";
        }
    }
}

