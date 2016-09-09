namespace ProofOfConcept.Geometry.Structures
{
    using Interfaces;
    using System;
    using System.Runtime.Serialization;
    using System.Xml;
    using System.Xml.Schema;

    [Serializable]
    public struct Point : IPoint
    {
        private float x;
        private float y;
        private float z;

        public static Point Empty { get { return new Point(0, 0, 0); } }

        public bool IsEmpty { get { return x == 0 && y == 0 && z == 0; } }

        public float X { get { return this.x; } set { this.x = value; } }

        public float Y { get { return this.y; } set { this.y = value; } }

        public float Z { get { return this.z; } set { this.z = value; } }

        public Point(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point(Point p)
        {
            this = p.Clone();
        }

        public static int Compare(Point p1, Point p2)
        {
            var tmp = p1.x.CompareTo(p2.x);
            if (tmp == 0)
            {
                tmp = p1.y.CompareTo(p2.y);
                if (tmp == 0)
                {
                    tmp = p1.z.CompareTo(p2.z);
                }
            }
            return tmp;
        }

        public int CompareTo(Point p)
        {
            return Compare(this, p);
        }

        public int CompareTo(object obj)
        {
            if (obj is Point)
            {
                var p = (Point)obj;
                return this.CompareTo(p);
            }
            else throw new InvalidCastException();
        }
        public static bool Equals(Point p1, Point p2)
        {
            return p1.x == p2.x && p1.y == p2.y && p1.z == p2.z;
        }

        public bool Equals(Point p)
        {
            return Equals(this, p);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() * y.GetHashCode() * z.GetHashCode();
        }
        public Point Clone()
        {
            return (Point)this.MemberwiseClone();
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }

        public XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        private static void CheckOverflow(double x, double y, double z)
        {
            if (x > float.MaxValue || y > float.MaxValue || z > float.MaxValue) throw new OverflowException();
            if (x < float.MinValue || y < float.MinValue || z < float.MinValue) throw new OverflowException();
        }

        public override string ToString()
        {
            return $"[x: {x}; y: {y}; z: {z}]";
        }
        public static Point operator +(Point p1, Point p2)
        {
            var x = (double)p1.x + p2.y;
            var y = (double)p1.y + p2.y;
            var z = (double)p1.z + p2.z;
            CheckOverflow(x, y, z);
            return new Point((float)x, (float)y, (float)z);
        }

        public static Point operator -(Point p1, Point p2)
        {
            var x = (double)p1.x - p2.y;
            var y = (double)p1.y - p2.y;
            var z = (double)p1.z - p2.z;
            CheckOverflow(x, y, z);
            return new Point((float)x, (float)y, (float)z);
        }

        public static Point operator *(Point p1, Point p2)
        {
            var x = (double)p1.x * p2.y;
            var y = (double)p1.y * p2.y;
            var z = (double)p1.z * p2.z;
            CheckOverflow(x, y, z);
            return new Point((float)x, (float)y, (float)z);
        }

        public static Point operator /(Point p1, Point p2)
        {
            var x = (double)p1.x / p2.y;
            var y = (double)p1.y / p2.y;
            var z = (double)p1.z / p2.z;
            CheckOverflow(x, y, z);
            return new Point((float)x, (float)y, (float)z);
        }

        public static Point operator %(Point p1, Point p2)
        {
            var x = (double)p1.x % p2.y;
            var y = (double)p1.y % p2.y;
            var z = (double)p1.z % p2.z;
            CheckOverflow(x, y, z);
            return new Point((float)x, (float)y, (float)z);
        }

        public static Point operator +(Point p, double n)
        {
            var x = p.x + n;
            var y = p.y + n;
            var z = p.z + n;
            CheckOverflow(x, y, z);
            return new Point((float)x, (float)y, (float)z);
        }

        public static Point operator +(double n, Point p)
        {
            return p + n;
        }

        public static Point operator -(Point p, double n)
        {
            var x = p.x - n;
            var y = p.y - n;
            var z = p.z - n;
            CheckOverflow(x, y, z);
            return new Point((float)x, (float)y, (float)z);
        }

        public static Point operator -(double n, Point p)
        {
            return p - n;
        }

        public static Point operator *(Point p, double n)
        {
            var x = p.x * n;
            var y = p.y * n;
            var z = p.z * n;
            CheckOverflow(x, y, z);
            return new Point((float)x, (float)y, (float)z);
        }

        public static Point operator *(double n, Point p)
        {
            return p * n;
        }

        public static Point operator /(Point p, double n)
        {
            var x = p.x / n;
            var y = p.y / n;
            var z = p.z / n;
            CheckOverflow(x, y, z);
            return new Point((float)x, (float)y, (float)z);
        }

        public static Point operator /(double n, Point p)
        {
            return p / n;
        }

        public static Point operator %(Point p, double n)
        {
            var x = p.x % n;
            var y = p.y % n;
            var z = p.z % n;
            CheckOverflow(x, y, z);
            return new Point((float)x, (float)y, (float)z);
        }

        public static Point operator %(double n, Point p)
        {
            return p % n;
        }

        public static Point operator +(Point p, long n)
        {
            return p + (double)n;
        }

        public static Point operator +(long n, Point p)
        {
            return p + (double)n;
        }

        public static Point operator -(Point p, long n)
        {
            return p - (double)n;
        }

        public static Point operator -(long n, Point p)
        {
            return p - (double)n;
        }

        public static Point operator *(Point p, long n)
        {
            return p * (double)n;
        }

        public static Point operator *(long n, Point p)
        {
            return p * (double)n;
        }

        public static Point operator /(Point p, long n)
        {
            return p / (double)n;
        }

        public static Point operator /(long n, Point p)
        {
            return p / (double)n;
        }

        public static Point operator %(Point p, long n)
        {
            return p % (double)n;
        }

        public static Point operator %(long n, Point p)
        {
            return p % (double)n;
        }

        public static Point operator -(Point p)
        {
            var x = (double)-p.x;
            var y = (double)-p.y;
            var z = (double)-p.z;
            CheckOverflow(x, y, z);
            return new Point((float)x, (float)y, (float)z);
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }
    }
}
