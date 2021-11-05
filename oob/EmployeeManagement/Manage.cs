using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement
{
    public class Manage:Person,TimeWork
    {
        public List<Employee> Employees = new List<Employee>();
        private string ManageId;

        public string PSManageId
        {
            get { return ManageId; }
            set { ManageId = value;  }
        }
        public Manage(string manageId, string name , int phoneNumber ,string address ):base(name,phoneNumber, address)
        {
            ManageId = manageId;
        }
        
        public Employee FindEmployeeId(string id)
        {
            return Employees.SingleOrDefault(s => s.EmployeeId.Equals(id));
        }
        public void AddEmployee(Employee employee)
        {
            if (FindEmployeeId(employee.EmployeeId) == null)
            {
                Employees.Add(employee);
                Console.WriteLine("Add Employee Success");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Add Employee Success");
                Console.WriteLine("-------------------------");
            }
            else
                Console.WriteLine("Enter Id Again");
        }    
        public void DeleteEmployee(string employeeid)
        {
            var DeleteEmployee= FindEmployeeId(employeeid);
            Employees.Remove(DeleteEmployee);
            Console.WriteLine("Delete Employee Success");
            Console.WriteLine("-------------------------");
        }

        public void ShowAllInfoEmployee()
        {
            Console.WriteLine(" ====================");
            Console.WriteLine($"Manager : {Name}");
            foreach (var ShowAllInfoEmployee in Employees)
            {
                ShowAllInfoEmployee.PrintInfoEmployee();
            }
        }

        public void PrintInfoManage()
        {
            Console.WriteLine($"Manager Id: {ManageId} || Name {Name} || " + 
                              $"Phone Number: {PhoneNumber} || AddRess: {Address}");
        }
        public void StartWork()
        {
            Console.WriteLine($"{Name} Start Work 8h30 Am");
        }

        public void EndWork()
        {
            Console.WriteLine($"{Name} End Work 4h30 Pm");

        }
    }
}