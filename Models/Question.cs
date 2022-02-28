using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POC.Models
{
    public class Question
    {
         [Key]
        public int QuestionId { get; set; }
        [Required]
        public string QuestionText { get; set; }
        [Required]
        public string Option1 { get; set; }
        [Required]
        public string Option2 { get; set; }
        public string Option3 { get; set; } 
        public string Option4 { get; set; }
        public int Answer { get; set; }
    }
}