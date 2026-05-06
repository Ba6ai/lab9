namespace ex2
{
    internal class Point
    {
        double _x;
        double _y;

        public Point(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        public Point(Point p)
        {
            this._x = p._x;
            this._y = p._y;
        }

        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public override string ToString()
        {
            return _x + " " + _y;
        }

        public double GetDistance(Point p2)
        {
            return Math.Sqrt(Math.Pow(p2._x - this._x, 2) + Math.Pow(p2._y - this._y, 2));
        }

        public static Point operator ++(Point P)
        {
            return new Point(P._x + 1, P._y);
        }

        public static Point operator --(Point P)
        {
            return new Point(P._x - 1, P._y);
        }

        public static explicit operator int(Point p)
        {
            return (int)p._x;
        }

        public static implicit operator double(Point p)
        {
            return p._y;
        }

        public static double operator +(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2._x - p1._x, 2) + Math.Pow(p2._y - p1._y, 2));
        }

        public static Point operator +(Point p, double val)
        {
            return new Point(p._x + val, p._y);
        }

        public static Point operator +(double val, Point p)
        {
            return new Point(p._x + val, p._y);
        }
    }
}