using System;

namespace AggregationASM
{
    public class Employee
    {
        public static string ID;
        public static string Name;
        public static EmployeeData _employeeData;

        //public Employee()
        //{ }
        public Employee(string id, string name, EmployeeData employeeData)
        {

            ID = id;
            Name = name;
            _employeeData = employeeData;
        }
        public void PrintInfo()
        {
            Console.WriteLine(
                $"ID: {ID} | Name: {Name} | Field: {_employeeData.Field} | Position: {_employeeData.Position} | " +
                $"Work Experience: {_employeeData.WorkExperience}");
        }

    }
}
