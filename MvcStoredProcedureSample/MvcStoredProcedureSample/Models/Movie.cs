using System;  
using System.ComponentModel.DataAnnotations;  
   
namespace MvcStoredProcedureSample.Models
{  
    public class Movie
   {  
        public int ID { get; set; }  
        [Required]  
        public string Name { get; set; }  
       [Required]  
        [Display(Name = "Release Date")]  
        public DateTime ReleaseDate { get; set; }  
        [Required]  
        public string Category { get; set; }  
    }  
}  
