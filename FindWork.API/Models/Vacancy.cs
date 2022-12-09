using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FindWork.API.Models
{
    public class Vacancy
    {
         [Key]
         public int vacancyId { get; set; }
        public string? vacancyname { get; set; } //
        public string? company { get; set; } //
        public string? category { get; set; }  //
        public DateTime? publishtime { get; set; }
        public int salary { get; set; }  //
        public string? location { get; set; } //
        public string? requires { get; set; }
        public string? offer { get; set; }
        public string? description { get; set; }
        public string? userId { get; set; }
        /*  
         public string companyphone { get; set; } = string.Empty;
        */
    }
}

