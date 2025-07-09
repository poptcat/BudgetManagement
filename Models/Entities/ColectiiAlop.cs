using System.ComponentModel.DataAnnotations;

namespace BudgetManagement.Models
{
    public class ColectiiAlop
    {
        [Key]
        public short Colectie { get; set; }
        
        [Required]
        [StringLength(80)]
        public string Nume { get; set; }
        
        public short An { get; set; }
        public short Luna { get; set; }
    }
}