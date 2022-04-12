
using System;
using System.ComponentModel.DataAnnotations;

namespace MudBlazor_CRUD.Models
{
    public class Country
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; } 
    }
}
