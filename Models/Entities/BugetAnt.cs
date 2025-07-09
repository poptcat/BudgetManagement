using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BudgetManagement.Models
{
    public class BugetAnt
    {
        [Key]
        public int BugetId { get; set; }
        
        [Required]
        public short Colectie { get; set; }
        
        [Required]
        public short An { get; set; }
        
        [Required]
        public DateTime Data { get; set; }
        
        [Required]
        public int SrsFinId { get; set; }
        
        [Required]
        public decimal Valoare { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Tip { get; set; }
        
        public string Obs { get; set; }
        
        [Required]
        public DateTime DataCont { get; set; }
        
        // Navigation properties
        public virtual SurseFin SurseFin { get; set; }
        public virtual ICollection<BugetPoz> BugetPozitii { get; set; }
    }
}