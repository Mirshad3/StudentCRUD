using MudBlazor_CRUD.ApplicationDbContext;
using MudBlazor_CRUD.Models;
using MudBlazor_CRUD.UnitofWork;
using MudBlazor_CRUD.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace MudBlazor_CRUD.Services
{
    public class StudentService : IStudentService
    {
        #region Property  
        private IRepository<Student> _repository; 
        private AppDbContext _appDbContext;
        private IClassService _classService;
        private ICountryService _countryService;
        #endregion

        #region Constructor  
        public StudentService(IRepository<Student> repository, AppDbContext appDbContext, IClassService classService, ICountryService countryService)
        {
            _repository = repository;
            _appDbContext = appDbContext;
            _classService = classService;
            _countryService = countryService;
        }
        #endregion

        public List<Student> GetStudents() => _repository.GetAll();

        public List<StudentPerClass> CountAllStudentsPerClass()
        {
            var students = _repository.GetAll();
            return students.GroupBy(c => new { c.Classesid })
                   .Select(c => new StudentPerClass
                   {
                       class_name = _classService.GetClasss().Where(m=>m.id == c.Key.Classesid).FirstOrDefault().class_name,
                       student_count = c.Count()
                   }).ToList();
        }
        public List<StudentPerCountry> CountAllStudentsPerCountry()
        {
            var students = _repository.GetAll();
            return students.GroupBy(c => new { c.Countryid })
                   .Select(c => new StudentPerCountry
                   {
                       country_name = _countryService.GetCountries().Where(m => m.id == c.Key.Countryid).FirstOrDefault().name,
                       student_count = c.Count()
                   }).ToList();
        }
        public void InsertStudent(Student customer) 
        {
            if (customer.id is 0) _repository.Insert(customer);
            else _repository.Update(customer);
        } 

        public void DeleteStudent(int id)
        {
            Student student = _appDbContext.Students.FirstOrDefault(c => c.id.Equals(id));
            _repository.Remove(student);
            _repository.SaveChanges();
        }
    }
}
