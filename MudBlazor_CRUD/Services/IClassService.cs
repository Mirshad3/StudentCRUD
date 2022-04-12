using MudBlazor_CRUD.Models;
using System.Collections.Generic;

namespace MudBlazor_CRUD.Services
{
   public interface IClassService
    {
        List<Classes> GetClasss();
        void InsertClass(Classes customer);
        void DeleteClass(int id);
    }
}
