 
using Microsoft.EntityFrameworkCore; 
using Microsoft.Extensions.DependencyInjection; 
using MudBlazor_CRUD.ApplicationDbContext; 
using System; 
using MudBlazor_CRUD.Models; 
using System.Linq;
public static class SeedDatabase
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
        {
            if (context.Country.Any())
            {
                return;
            }

            context.Country.AddRange(
                new Country
                {  
                    name = "India"
                },

                new Country
                {   
                    name = "Oman"
                },


                new Country
                {    
                    name = "Qatar"
                }
                ); 

            context.Classes.AddRange(
               new Classes
               {  
                   class_name = "Maths"
               },

               new Classes
               {    
                   class_name = "Science"
               },


               new Classes
               {    
                   class_name = "English"
               }
               );
            context.SaveChanges();
            if (context.Students.Any())
            {
                return;
            }
            context.Students.AddRange(
               new Student
               {
                   
                   Classesid = 1,
                   Countryid =1,
                   date_of_birth = new DateTime(1980, 1, 1),
                   name = "Arshad"
               },

               new Student
               {
                   
                   Classesid = 2,
                   Countryid = 3,
                   date_of_birth = new DateTime(1988, 1, 1),
                   name = "Mirshad"
               },


               new Student
               {
                 
                   Classesid = 1,
                   Countryid = 2,
                   date_of_birth = new DateTime(1994, 1, 1),
                   name = "Irshad"
               },
               new Student
                {
                   
                   Classesid = 3,
                   Countryid = 3,
                   date_of_birth = new DateTime(1999, 9, 1),
                   name = "Rashad"
               },


               new Student
               {
                   
                   Classesid = 2,
                   Countryid = 1,
                   date_of_birth = new DateTime(1997, 5, 2),
                   name = "Murshid"
               }
               );
            context.SaveChanges();
        }
    }
}