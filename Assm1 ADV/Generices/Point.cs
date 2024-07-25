using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm1_ADV.Generices
{
    internal class Point : IComparable<Point>
    {
        public Point()
        {

        }
        public int X {get; set;}
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"Point: ({X}, {Y})";
        }

        //public int CompareTo(object? obj)
        //{
        //    if(obj is Point PassedPoint)
        //    {
        //        if(this.X == PassedPoint.X)
        //            return this.Y.CompareTo(PassedPoint.Y);
        //        else
        //            return this.X.CompareTo(PassedPoint.X);
        //    }
        //    return 1;
        //}

        public int CompareTo(Point? other)
        {
            if(other is null) return 1 ;
            if(X ==  other.X)
                return Y.CompareTo(other.Y);
            else
                return X.CompareTo(other.X);
        }

        public int CompareTo(Point other)
        {
            throw new NotImplementedException();
        }
    }
}
