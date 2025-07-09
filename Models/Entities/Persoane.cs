using System.ComponentModel.DataAnnotations;

namespace BudgetManagement.Models
{
    public class Persoane
    {
        [Key]
        public int PersoanaId { get; set; }
        
        [Required]
        public short Colectie { get; set; }
        
        [Required]
        [StringLength(40)]
        public string Nume { get; set; }
        
        public int? PersId { get; set; }
        
        public byte Blocat { get; set; } = 0;
        
        public byte Spec { get; set; } = 0;
        
        public byte Contab { get; set; } = 0;
        
        public byte Cfp { get; set; } = 0;
        
        public byte OrdCred { get; set; } = 0;
        
        [StringLength(13)]
        public string Cnp { get; set; }
        
        [StringLength(30)]
        public string Cont { get; set; } = "";
    }
}