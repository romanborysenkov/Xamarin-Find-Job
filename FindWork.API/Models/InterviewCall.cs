using System;
using System.ComponentModel.DataAnnotations;

namespace FindWork.API.Models
{
    public class InterviewCall
    {
        [Key]
       public int Id { get; set; }

        public string? HRId { get; set; }

        public string? WorkerId { get; set; }

        public DateTime Called { get; set; }
    }
}

