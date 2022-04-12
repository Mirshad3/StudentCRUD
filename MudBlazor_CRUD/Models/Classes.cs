
using System;
using System.ComponentModel.DataAnnotations;

namespace MudBlazor_CRUD.Models
{
    public class Classes
    {
        [Key]
        public int id { get; set; }
        public string class_name { get; set; } 
    }
}
