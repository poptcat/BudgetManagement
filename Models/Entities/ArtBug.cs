using System.ComponentModel.DataAnnotations;

namespace BudgetManagement.Models
{
    public class ArtBug
    {
        [Key]
        public int ArtBugId { get; set; }
        
        [Required]
        public short An { get; set; }
        
        [Required]
        [StringLength(10)]
        public string Cod { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Denumire { get; set; }
        
        [Required]
        public short Colectie { get; set; }
        
        public decimal TipArt { get; set; } = 4;
        
        public int? ArtBugIdp { get; set; }
        
        [Required]
        [StringLength(10)]
        public string CodAfis { get; set; }
        
        public short Ordine { get; set; } = 1;
        
        public byte Blocat { get; set; } = 0;
    }
}