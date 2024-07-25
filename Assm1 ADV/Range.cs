using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm1_ADV
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; }
        public T Max { get; }

    public Range(T min, T max)
    {
        if (min.CompareTo(max) > 0)
        {
            throw new ArgumentException("Min value should be less than or equal to Max value.");
        }

        Min = min;
        Max = max;
    }


        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public dynamic Length()
        {
            if (typeof(T) == typeof(DateTime))
            {
                DateTime min = (DateTime)(object)Min;
                DateTime max = (DateTime)(object)Max;
                return max - min;
            }
            else
            {
                dynamic min = Min;
                dynamic max = Max;
                return max - min;
            }
        }
    }
}