
using System;
using System.ComponentModel.DataAnnotations;

namespace MudBlazor_CRUD.ViewModel
{
    public class StudentPerCountry
    { 
        public string country_name { get; set; }
        public int student_count { get; set; } 
    }
}
