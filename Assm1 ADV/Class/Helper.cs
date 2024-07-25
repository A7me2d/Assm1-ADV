using Assm1_ADV.Generices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm1_ADV.Class
{
    internal class Helper<T>
    {
        //public

        #region Non Generic
        //public static void SWAP(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref double X, ref double Y)
        //{
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref Point X, ref Point Y)
        //{
        //    Point Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void BubbleSort(int[] array)
        //{
        //    if (array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            for(int k = 0; k < array.Length - i - 1; k++)
        //            {
        //                if (array[k] > array[k + 1])

        //                    Helper.SWAP<int>(ref array[k], ref array[k + 1]);

        //            }
        //        }
        //    }
        //}
        #endregion

        #region Generic

        public static void BubbleSort<T1>(T1[] array) where T1 : IComparable
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int k = 0; k < array.Length - i - 1; k++)
                    {
                        if (array[k].CompareTo(array[k + 1]) == 1)

                           Helper<T1>.SWAP(ref array[k], ref array[k + 1]);

                    }
                }
            }
        }

        public static void SWAP(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }


        //public static int SearchArray(T[] array, T value)
        //{
        //    if(array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {

        //            if (value.Equals(array[i]))
        //                return i;
        //        }
        //    }
        //    return -1;
        //}
        #endregion


    }
}
