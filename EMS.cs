using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    public class Employee
    {
        protected int EmpNo { get; set; }
        protected string EmpName { get; set; }
        protected double Salary { get; set; }
        protected double HRA { get; set; }
        protected double TA { get; set; }
        protected double DA { get; set; }
        protected double PF { get; set; }
        protected double TDS { get; set; }
        protected double NetSalary { get; set; }
        protected double GrossSalary { get; set; }

        public Employee(int empNo, string empName, double salary)
        {
            EmpNo = empNo;
            EmpName = empName;
            Salary = salary;
        }
        public double Grosssalary()
        {
            if (Salary < 5000)
            {
                HRA = ((Salary / 100) * 10);
                TA = ((Salary / 100) * 5);
                DA = ((Salary / 100) * 15);
                GrossSalary = ((Salary) + (HRA + TA + DA));
            }
            else if (Salary < 10000)
            {
                HRA = ((Salary / 100) * 15);
                TA = ((Salary / 100) * 10);
                DA = ((Salary / 100) * 20);
                GrossSalary = ((Salary) + (HRA + TA + DA));
            }
            else if (Salary < 15000)
            {
                HRA = ((Salary / 100) * 20);
                TA = ((Salary / 100) * 15);
                DA = ((Salary / 100) * 25);
                GrossSalary = ((Salary) + (HRA + TA + DA));
            }
            else if (Salary < 20000)
            {
                HRA = ((Salary / 100) * 25);
                TA = ((Salary / 100) * 20);
                DA = ((Salary / 100) * 30);
                GrossSalary = ((Salary) + (HRA + TA + DA));
            }
            else
            {
                HRA = ((Salary / 100) * 25);
                TA = ((Salary / 100) * 20);
                DA = ((Salary / 100) * 35);
                GrossSalary = ((Salary) + (HRA + TA + DA));
            }
             return GrossSalary;
        }
        public virtual void CalculateSalary()
        {
            PF = (GrossSalary / 100) * 10;
            TDS = (GrossSalary / 100) * 18;
            NetSalary = (GrossSalary - (PF + TDS));
        }
        public virtual void Gsal()
        {
            GrossSalary = (Grosssalary());
            //Console.ReadLine(GrossSalary);
            Console.WriteLine(GrossSalary);
            
        }
    }
    class Manager : Employee
    {
        private double PetrolAllowance { get; set; }
        private double FoodAllowance { get; set; }
        private double OtherAllowance { get; set; }

        public Manager(int empNo, string empName, double salary) : base(empNo, empName, salary)
        {
            PetrolAllowance = Salary * 8 / 100;
            FoodAllowance = Salary * 13 / 100;
            OtherAllowance = Salary * 3 / 100;
        }
        public override void Gsal()
        {
            GrossSalary = (Grosssalary());
            GrossSalary = (GrossSalary + PetrolAllowance + FoodAllowance + OtherAllowance);
            Console.WriteLine(GrossSalary);
        }
        public override void CalculateSalary()
        {
            NetSalary = GrossSalary - (PF + TDS);
        }
    }

    class MarketingExecutive : Employee
    {
        private double kilometertravel { get; set; }
        private double TourAllowences { get; set; }
        private double TelephoneAllowances { get; set; }

        public MarketingExecutive(int empNo, string empName, double salary, double kmt) : base(empNo, empName, salary)
        {
            kilometertravel = kmt;
            TourAllowences = kilometertravel * 5;
            TelephoneAllowances = 1000;

        }
        public override void Gsal()
        {
            GrossSalary = (Grosssalary());
            GrossSalary = (GrossSalary + TourAllowences + TelephoneAllowances);
            Console.WriteLine(GrossSalary);
        }
        public override void CalculateSalary()
        {
            GrossSalary = (Grosssalary());
            NetSalary = GrossSalary - (PF + TDS);
        }

    }
    class main
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee(1002, "saekumaar", 20000);
            Manager obj1 = new Manager(101, "Ram", 20000);
            MarketingExecutive obj2 = new MarketingExecutive(01, "krishna", 20000, 10);
           // obj.Grosssalary();
            obj.CalculateSalary();
            //Obj.displayEmployeeDetails();
            obj.Gsal();
            obj1.Gsal();
            obj2.Gsal();

        }

    }

}
