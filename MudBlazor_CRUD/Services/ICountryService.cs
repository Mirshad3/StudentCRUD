using MudBlazor_CRUD.Models;
using System.Collections.Generic;

namespace MudBlazor_CRUD.Services
{
   public interface ICountryService
    {
        List<Country> GetCountries();
        void InsertCountry(Country customer);
        void DeleteCountry(int id);
    }
}
