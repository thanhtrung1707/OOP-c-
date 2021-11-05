using System;
using System.Collections.Generic;

namespace Association
{
    public class Department
    {
        public Department(){}
        
        public string Department_Name { get; set; }

        public void Employee_Name(Employee Obj)
        {
            Obj.Employee_Info(this);
        }
    }


}