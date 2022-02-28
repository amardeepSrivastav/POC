using System.ComponentModel.DataAnnotations;

namespace POC.Models
{
    public class SubOption
    {
        [Key]
        public int SubOptionId { get; set; }
        [Required]
        public string SubOptionText { get; set; }
        [Required]
        public int OptionId { get; set; }
    }
}