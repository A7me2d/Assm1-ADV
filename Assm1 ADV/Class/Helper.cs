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

        #endregion

        #region Generic
        public static void SWAP<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }


        public static int SearchArray(T[] array, T value)
        {
            if(array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {

                    if (value.Equals(array[i]))
                        return i;
                }
            }
            return -1;
        }
        #endregion


    }
}
