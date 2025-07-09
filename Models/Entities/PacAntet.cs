using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BudgetManagement.Models
{
    public class PacAntet
    {
        [Key]
        public int PacAntId { get; set; }
        
        [Required]
        public short Colectie { get; set; }
        
        [Required]
        public DateTime DataPac { get; set; }
        
        [Required]
        [StringLength(20)]
        public string NumarPac { get; set; }
        
        public int? BenefId { get; set; }
        
        [StringLength(30)]
        public string Sursa { get; set; }
        
        public int? PersoanaId { get; set; }
        
        [StringLength(200)]
        public string Scop { get; set; }
        
        public byte? Stare { get; set; }
        
        public decimal ValTotal { get; set; } = 0;
        
        [Required]
        [StringLength(1)]
        public string Provenienta { get; set; }
        
        public int? PersSpecId { get; set; }
        public int? PersContabId { get; set; }
        public int? PersCfppId { get; set; }
        public int? PersCfpdId { get; set; }
        public int? PersOrdcredId { get; set; }
        public int? CompartId { get; set; }
        
        [Required]
        public DateTime DataCont { get; set; } = DateTime.Now;
        
        public int? PersplId { get; set; }
        
        // Navigation properties
        public virtual Beneficiari Beneficiar { get; set; }
        public virtual Persoane Persoana { get; set; }
        public virtual ICollection<PacLinii> PacLinii { get; set; }
    }
}
