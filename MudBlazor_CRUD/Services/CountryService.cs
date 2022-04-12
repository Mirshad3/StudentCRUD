using MudBlazor_CRUD.ApplicationDbContext;
using MudBlazor_CRUD.Models;
using MudBlazor_CRUD.UnitofWork;
using System.Collections.Generic;
using System.Linq;

namespace MudBlazor_CRUD.Services
{
    public class CountryService : ICountryService
    {
        #region Property  
        private IRepository<Country> _repository;
        private AppDbContext _appDbContext;
        #endregion

        #region Constructor  
        public CountryService(IRepository<Country> repository, AppDbContext appDbContext)
        {
            _repository = repository;
            _appDbContext = appDbContext;
        }
        #endregion

        public List<Country> GetCountries() => _repository.GetAll();

        public void InsertCountry(Country customer) 
        {
            if (customer.id is 0) _repository.Insert(customer);
            else _repository.Update(customer);
        } 

        public void DeleteCountry(int id)
        {
            Country Country = _appDbContext.Country.FirstOrDefault(c => c.id.Equals(id));
            _repository.Remove(Country);
            _repository.SaveChanges();
        }
    }
}
