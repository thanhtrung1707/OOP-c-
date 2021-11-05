using System;

namespace Aggregation
{
    public class Employee
    {
        public int id;  
        public string name;  
        public Address address;//Employee HAS-A Address  
        public Employee(int _id, string _name, Address _address)  
        {  
            _id = id;  
            _name = name;  
            _address = address;  
        }  
        public void display()  
        {  
            Console.WriteLine(id + " " + name + " " +   
                              address.AddressLine + " " + address.City + " " + address.State);  
        }   
    }
}