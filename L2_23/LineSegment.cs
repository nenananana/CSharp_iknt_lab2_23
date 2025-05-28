namespace L2_23
{
    internal class LineSegment
    {
        private double _x;
        public double X
        {
            get => _x;
            set => _x = value;
        }

        private double _y;
        public double Y
        {
            get => _y;
            set => _y = value;
        }

        public LineSegment(double x, double y)
        {
            _x = x;
            _y = y;
        }

        // проверка пересечения отрезков
        public static bool Intersects(LineSegment segment1, LineSegment segment2)
        {
            return !(segment1.Y < segment2.X || segment2.Y < segment1.X);
        }

        // вычисление длины отрезка
        public static double operator !(LineSegment segment)
        {
            return Convert.ToDouble(Convert.ToDecimal(segment.Y) - Convert.ToDecimal(segment.X));
        }

        // расширение отрезка на 1 вправо и влево
        public static LineSegment operator ++(LineSegment segment)
        {
            return new LineSegment(segment.X - 1, segment.Y + 1);
        }

        // неявное к int
        public static implicit operator int(LineSegment segment)
        {
            return (int)segment.X;
        }

        // явное к double
        public static explicit operator double(LineSegment segment)
        {
            return segment.Y;
        }

        // левосторонняя операция, уменьшается координата х
        public static LineSegment operator -(LineSegment segment, int value)
        {
            return new LineSegment(segment.X - value, segment.Y);
        }

        // правосторонняя операция, уменьшается координата y
        public static LineSegment operator -(int value, LineSegment segment)
        {
            return new LineSegment(segment.X, segment.Y - value);
        }

        public override string ToString()
        {
            return $"\n[{_x}, {_y}]";
        }
    }
}

