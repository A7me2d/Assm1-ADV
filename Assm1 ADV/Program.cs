using Assm1_ADV.Class;
using Assm1_ADV.Generices;
using System.Drawing;

namespace Assm1_ADV
{
    internal class Program
    {
        static void Main(string[] args)
        {

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


        }
    }
}
