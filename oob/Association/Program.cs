using System;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Employee_Name = "Thanh Trung";
            Department department = new Department();
            department.Department_Name = "Tom";
                department.Employee_Name(employee);

        }
    }
}