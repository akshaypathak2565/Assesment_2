using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class Employee
    {
        int Empno;
        string Ename;
        int Deptno;
        decimal Salary;
        decimal Commission;

        public void setEmployee(int eno, string ename, int deptno, decimal salary, decimal commission)
        {
            this.Empno = eno;
            this.Ename = ename;
            this.Deptno = deptno;
            this.Salary = salary;
            this.Commission = commission;
        }

        public void showEmployee()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Id: {this.Empno}");
            Console.WriteLine($"Name: {this.Ename}");
            Console.WriteLine($"Department No: {this.Deptno}");
            Console.WriteLine($"Salary : {this.Salary}");
            Console.WriteLine($"Commission : {this.Commission}");
        }

        public decimal getTotalSalary()
        {
            return this.Salary + this.Commission;
        }

        public bool isTopEmployee()
        {
            return this.Commission > this.Salary ? true : false;
        }
    }
    internal class Question2
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();


            Action<int, string, int, decimal, decimal> setEmployee = employee.setEmployee;
            setEmployee(101, "Harsh Kumar", 3, 10000, 50000);

            Action showEmployee = employee.showEmployee;
            showEmployee();

            Func<decimal> totalSalary = employee.getTotalSalary;
            Console.WriteLine($"Total Salary {totalSalary.Invoke()}");

            Func<bool> isTopEmployee = employee.isTopEmployee;
            bool res = isTopEmployee();

            if (res)
            {
                Console.WriteLine("Top Employee");
            }
            else
            {
                Console.WriteLine("Work hard and smart to become Top Employee");
            }
        }
    }
}