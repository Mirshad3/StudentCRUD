using MudBlazor_CRUD.Models;
using MudBlazor_CRUD.ViewModel;
using System.Collections.Generic;

namespace MudBlazor_CRUD.Services
{
   public interface IStudentService
    {
        List<Student> GetStudents();
        void InsertStudent(Student customer);
        void DeleteStudent(int id);
        List<StudentPerClass> CountAllStudentsPerClass();
        List<StudentPerCountry> CountAllStudentsPerCountry();
    }
}
