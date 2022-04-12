
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MudBlazor_CRUD.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        [BindProperty, DataType(DataType.Date)]
        public DateTime? date_of_birth { get; set; }
        
        public int Countryid { get; set; }
        public int Classesid { get; set; }
        [ForeignKey("Countryid")]
        public Country Country { get; set; }
        [ForeignKey("Classesid")]
        public Classes Classes { get; set; }
    }
}
