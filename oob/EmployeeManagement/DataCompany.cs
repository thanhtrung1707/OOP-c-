using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement
{
    public class DataCompany
    {
        public string Name;
        private List<Manage> _listManage = new List<Manage>();

        public DataCompany(string name)
        {
            Name = name;
            _listManage = new List<Manage>();
        }

        public List<Manage> ListManage
        {
            get { return _listManage; }
            
        }

        public Manage FindManageId(string id)
        {
            return ListManage.SingleOrDefault(i => i.PSManageId.Equals(id));
        }

        public void AddManage(Manage manage)
        {
            if (FindManageId(manage.PSManageId) == null)
            {
                _listManage.Add(manage);
            }
            else
                Console.WriteLine("Return ID");
        }
        public void DeleteManage(string id)
        {
            var DeleteManage = FindManageId(id);
            ListManage.Remove(DeleteManage);
            Console.WriteLine("Remove Manager success");
        }
        public void showAllInfoManage()
        {
           
            Console.WriteLine($"ShowInformation All Manager to  Company {Name} ");
            foreach (Manage showAllInfomManage in _listManage)
            {
                showAllInfomManage.PrintInfoManage();
            }
        }
    }
}