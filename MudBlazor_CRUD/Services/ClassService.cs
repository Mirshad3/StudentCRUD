using MudBlazor_CRUD.ApplicationDbContext;
using MudBlazor_CRUD.Models;
using MudBlazor_CRUD.UnitofWork;
using System.Collections.Generic;
using System.Linq;

namespace MudBlazor_CRUD.Services
{
    public class ClassService : IClassService
    {
        #region Property  
        private IRepository<Classes> _repository;
        private AppDbContext _appDbContext;
        #endregion

        #region Constructor  
        public ClassService(IRepository<Classes> repository, AppDbContext appDbContext)
        {
            _repository = repository;
            _appDbContext = appDbContext;
        }
        #endregion

        public List<Classes> GetClasss() => _repository.GetAll();

        public void InsertClass(Classes customer) 
        {
            if (customer.id is 0) _repository.Insert(customer);
            else _repository.Update(customer);
        } 

        public void DeleteClass(int id)
        {
            Classes Class = _appDbContext.Classes.FirstOrDefault(c => c.id.Equals(id));
            _repository.Remove(Class);
            _repository.SaveChanges();
        }
    }
}
