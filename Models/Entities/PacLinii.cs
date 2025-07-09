using System.ComponentModel.DataAnnotations;

namespace BudgetManagement.Models
{
    public class PacLinii
    {
        [Key]
        public int PacLinId { get; set; }
        
        [Required]
        public int PacAntId { get; set; }
        
        [Required]
        public int SrsFinId { get; set; }
        
        [Required]
        public int ArtBugId { get; set; }
        
        [StringLength(3)]
        public string MndId { get; set; } = "";
        
        public decimal ValMnd { get; set; } = 0;
        public decimal CursMnd { get; set; } = 0;
        public decimal ValLei { get; set; } = 0;
        public decimal ValBugAprobat { get; set; } = 0;
        public decimal ValBugAngajat { get; set; } = 0;
        public decimal ValPaAsteptare { get; set; } = 0;
        public decimal ValBugAprobatm { get; set; } = 0;
        public decimal ValBugAngajatm { get; set; } = 0;
        public decimal ValPaAsteptarem { get; set; } = 0;
        
        public int PacLinIdp { get; set; } = -1;
        public int? ContId { get; set; }
        
        // Navigation properties
        public virtual PacAntet PacAntet { get; set; }
        public virtual SurseFin SurseFin { get; set; }
        public virtual ArtBug ArtBug { get; set; }
    }
}