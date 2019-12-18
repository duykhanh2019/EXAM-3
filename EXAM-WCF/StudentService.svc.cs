using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using static EXAM_WCF.Student;

namespace EXAM_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentService.svc or StudentService.svc.cs at the Solution Explorer and start debugging.
    public class StudentService : IStudentService
    {
        static IStudentRepository repository = new StudentRepository();
        public List<Student> GetStudentList()
        {
            return repository.GetAllStudent();
        }
    }
}
