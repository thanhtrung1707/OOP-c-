using System;

namespace EmployeeManagement
{
    public class Employee: Person,TimeWork
    {
        public string EmployeeId;
        public int Age;
        public string Level;
        public int Salary;

        public string PSEmployeeId
        {
            get { return EmployeeId; }
            set { PSEmployeeId = value; }
        }

        public Employee(string employeeId, string name,long phoneNumber,string address,int age, string level, int salary)
            :base(name,phoneNumber, address)
        {
            EmployeeId = employeeId;
            Age = age;
            Salary = salary;
            Level = level;

        }
        public void PrintInfoEmployee()
        {
            Console.WriteLine(
                $"Information Employee is: {EmployeeId} || FulName: {Name} || Age:  {Age} || Address: {Address}  || " +
                $"Phone : {PhoneNumber} ||Level : {Level} || Salary : {Salary} Do La ");

        }

        public void StartWork()
        {
            Console.WriteLine($"{Name} Start Work 7h30 Am");
        }

        public void EndWork()
        {
            Console.WriteLine($"{Name} End Work 17h Pm");

        }
    }
}