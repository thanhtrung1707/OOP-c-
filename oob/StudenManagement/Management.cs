using System;
using System.Collections.Generic;
using System.Linq;
namespace StudenManagement
{
    public class Management
    {
        private int GenerateID()
        {
            int max = 1;
            if (ListStudent != null && ListStudent.Count > 0)
            {
                max = ListStudent[0].ID;
                foreach (Student sv in ListStudent)
                {
                    if (max < sv.Id)
                    {
                        max = sv.Id;
                    }
                }
                max++;
            }
            return max;
        }

        public IEnumerable<Student> ListStudent { get; set; }

        public int NumberOfStudent()
        {
            int Count = 0;
            if (ListStudent != null)
            {
                Count = ListStudent.Count;
            }
            return Count;
        }

        public void EnterStudent()
        {
            Student student = new Student();
            student.Id = GenerateID();
            Console
        }
        public void UpdateSinhVien(int ID)
        public void SortByID()
        public void SortByName()
        public void SortByMediumScore()
        public Student FindByID(int ID)
        public List<Student> FindByName(string keyword)
        public bool DeleteById(int ID)
        private void TinhDTB(Student sv)
        private void Ability(Student sv)
        public void ShowStudent(List<Student> liststudent)
        public List<Student> GetListStudent()

        
    }
}