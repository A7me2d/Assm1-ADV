﻿using Assm1_ADV.Generices;
using Assm1_ADV.Class;
using System.Drawing;
using Point = Assm1_ADV.Generices.Point;

namespace Assm1_ADV
{
    internal class Program
    {
        static void Main(string[] args)
        {


          #region Q1 Bubble Sort
            //int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            //Console.WriteLine("Original array: " + string.Join(", ", arr));

            //BubbleSort.OptimizedBubbleSort(arr);

            //Console.WriteLine("Sorted array: " + string.Join(", ", arr));
            #endregion

            #region Q2 generic 
            //var intRange = new Range<int>(5, 10);
            //Console.WriteLine($"Is 7 in range: {intRange.IsInRange(7)}");
            //Console.WriteLine($"Length of range: {intRange.Length()}"); 

            //var doubleRange = new Range<double>(1.5, 4.5);
            //Console.WriteLine($"Is 3.2 in range: {doubleRange.IsInRange(3.2)}");
            //Console.WriteLine($"Length of range: {doubleRange.Length()}");

            //var dateRange = new Range<DateTime>(new DateTime(2020, 1, 1), new DateTime(2020, 12, 31));
            //TimeSpan length = dateRange.Length();
            //Console.WriteLine($"Is 2020-06-15 in range: {dateRange.IsInRange(new DateTime(2020, 6, 15))}");
            //Console.WriteLine($"Length of range: {length.Days} days");

            #region Generics [SWAP EX]

            //int A = 10, B = 30;
            //Console.WriteLine($" A={A}");
            //Console.WriteLine($" B={B}");

            //Helper<int>.SWAP(ref A, ref B);

            //Console.WriteLine("After Swapping");
            //Console.WriteLine($" A={A}");
            //Console.WriteLine($" B={B}");


            //double A = 2.2, B = 3.3;
            //Console.WriteLine($" A={A}");
            //Console.WriteLine($" B={B}");

            //Helper<double>.SWAP(ref A, ref B);

            //Console.WriteLine("After Swapping");
            //Console.WriteLine($" A={A}");
            //Console.WriteLine($" B={B}");

            //Point P01 = new Point(1, 2);
            //Point P02 = new Point(10, 20);

            //Console.WriteLine(P01);
            //Console.WriteLine(P02);

            //Helper<Point>.SWAP(ref P01, ref P02);

            //Console.WriteLine("After Swapping");
            //Console.WriteLine(P01);
            //Console.WriteLine(P02);

            #endregion


            #region Generics [Search Ex]

            //int[] Number = { 4,5, 6, 9, 3, 2, 8, 1, 7 };

            //int Index = Helper<int>.SearchArray(Number , 15);

            //Console.WriteLine($"Index of 6 is ",Index);

            //Employee E1 = new Employee() { Id = 10 , Name = "Ahmed" , Salary = 1000};
            //Employee E2 = new Employee() { Id = 20 , Name = "Amr" , Salary = 5000};

            //if(E1 == E2)
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");

            //if (E1.Equals(E2))
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");


            //Employee E1 = new Employee() { Id = 10, Name = "Ahmed", Salary = 1000 };
            //Employee E2 = new Employee() { Id = 20 , Name = "Amr" , Salary = 5000};
            //Employee E3 = new Employee() { Id = 50 , Name = "Hany" , Salary = 6000};

            //Employee[] employees = new Employee[2]
            //{
            //    E1 , E2
            //};

            //int Index = Helper<Employee>.SearchArray(employees, E1);

            //    Console.WriteLine( Index);
            #endregion

            #region GetHashCode
            //Employee E1 = new Employee() { Id = 10  , Name = "Ahmed" , Salary = 1000};
            //Employee E2 = new Employee() { Id = 1000, Name = "Ahmed" , Salary = 10};

            //Console.WriteLine($"HashCode of Employee 1 = {E1.GetHashCode()}");
            //Console.WriteLine($"HashCode of Employee 2 = {E2.GetHashCode()}");
            #endregion

            #region Sort
            //int[] Numbers = { 12, 25, 3, 6, 9, 5, 20, 1, 2, 10 };
            //foreach (int i in Numbers) 
            //    Console.Write($" {i}");

            //Helper<int>.BubbleSort(Numbers);

            //foreach (int i in Numbers)
            //    Console.Write($" {i}");


            //Employee[] employees = new Employee[]
            //{
            //    new Employee() { Id = 10, Name = "Ahmed", Salary = 2000 },
            //    new Employee() { Id = 20, Name = "Hany" , Salary = 9000 },
            //    new Employee() { Id = 30, Name = "taha" , Salary = 1000 },
            //    new Employee() { Id = 40, Name = "makram" , Salary = 10000 },
            //};

            //Helper<Employee>.BubbleSort(employees);

            //foreach (Employee employee in employees)
            //    Console.WriteLine(employee);

            //Point[] points =
            //{
            //    new Point(7 , 2 ),
            //    new Point(2 , 5 ),
            //    new Point(6 , 4 ),
            //    new Point(7 , 3 ),
            //    new Point(1 , 2 ),
            //    new Point(9 , 2),
            //};
            //Helper<Point>.BubbleSort(points);
            //foreach (Point p in points)
            //    Console.WriteLine(p);

            
            #endregion


        }
    }
}
