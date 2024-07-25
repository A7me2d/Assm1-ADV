using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm1_ADV.Generices
{
    internal class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}" ;
        }

        #region Operator Overloading
        public static bool operator ==(Employee left, Employee right)
        {
            //return (left.Id == right.Id) && (left.Name == right.Name) && (left.Salary == right.Salary);
            return left.Equals(right);
        }
        public static bool operator !=(Employee left, Employee right)
        {
            //return (left.Id != right.Id) || (left.Name != right.Name) || (left.Salary != right.Salary);
            return !left.Equals(right);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id.GetHashCode() , Name.GetHashCode() , Salary.GetHashCode());
        }
        #endregion

    }
}
