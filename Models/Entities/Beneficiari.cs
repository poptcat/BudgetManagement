using System.ComponentModel.DataAnnotations;

namespace BudgetManagement.Models
{
    public class Beneficiari
    {
        [Key]
        public int BenefId { get; set; }
        
        [Required]
        public short Colectie { get; set; }
        
        [Required]
        [StringLength(15)]
        public string Cod { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Denumire { get; set; }
        
        [StringLength(200)]
        public string Adresa { get; set; }
        
        public byte Blocat { get; set; } = 0;
        
        public byte Incasari { get; set; } = 0;
        
        public byte Salarii { get; set; } = 0;
        
        [StringLength(15)]
        public string CodFiscal { get; set; }
        
        public byte Tip { get; set; } = 1;
    }
}