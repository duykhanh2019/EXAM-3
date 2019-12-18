using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace EXAM_WCF
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

      
        public interface IStudentRepository
        {
            List<Student> GetAllStudent();
        }

        public class StudentRepository : IStudentRepository
        {
            private List<Student> students = new List<Student>();
           
            public List<Student> GetAllStudent()
            {
                MyDbContext db = new MyDbContext();
                students = db.Students.ToList();
                return students;
            }
        }
    }
}