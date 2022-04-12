
using System;
using System.ComponentModel.DataAnnotations;

namespace MudBlazor_CRUD.ViewModel
{
    public class StudentPerClass
    { 
        public string class_name { get; set; }
        public int student_count { get; set; } 
    }
}
