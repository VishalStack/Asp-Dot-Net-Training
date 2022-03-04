using System.Collections.Generic;

namespace CRUDinMVC.Models
{
    public interface IStudentDBHandle
    {
        bool AddStudent(StudentModel smodel);
        bool DeleteStudent(int id);
        List<StudentModel> GetStudent();
        bool UpdateDetails(StudentModel smodel);
    }
}