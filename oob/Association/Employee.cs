using System;

namespace Association
{
    public class Employee
    {
        public Employee(){}
        
        public string Employee_Name { get; set; }

        public void Employee_Info(Department Obj)
        {
            Console.WriteLine($"Employee is {Obj.Department_Name} and Department {Employee_Name}");
        }
        

    }
    }
