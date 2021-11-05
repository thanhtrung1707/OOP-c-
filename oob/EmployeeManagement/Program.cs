using System;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            DataCompany Garena = new DataCompany("Company Game");
            Employee Trung = new Employee("A1", "Nguyen Thanh Trung", 09444111444, "Dong ha", 20,"Senior",2000);
            Manage Minh = new Manage("Manager1","Nguyen Van Minh",0922233345,"Da Nang");
            Garena.AddManage(Minh);
            Garena.showAllInfoManage();
            Minh.StartWork();
            Minh.EndWork();
            Minh.AddEmployee(new Employee("a2","Nguyen Anh",0945134123,"Da Nang",22,"Pro",3000 ));
            Minh.AddEmployee(new Employee("a3","Nguyen Phuoc",012345668,"Da Nang",20,"vippro",4000));
            Minh.ShowAllInfoEmployee();
            Trung.StartWork();
            Trung.EndWork();
            Console.ReadLine();
        }
    }
}