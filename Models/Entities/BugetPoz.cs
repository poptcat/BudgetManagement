
using System.ComponentModel.DataAnnotations;

namespace BudgetManagement.Models
{
    public class BugetPoz
    {
        public int BugetId { get; set; }
        public int ArtBugId { get; set; }
        
        public decimal V1 { get; set; } = 0;
        public decimal V2 { get; set; } = 0;
        public decimal V3 { get; set; } = 0;
        public decimal V4 { get; set; } = 0;
        public decimal V5 { get; set; } = 0;
        public decimal V6 { get; set; } = 0;
        public decimal V7 { get; set; } = 0;
        public decimal V8 { get; set; } = 0;
        public decimal V9 { get; set; } = 0;
        public decimal V10 { get; set; } = 0;
        public decimal V11 { get; set; } = 0;
        public decimal V12 { get; set; } = 0;
        
        public int? ContId { get; set; }
        
        // Navigation properties
        public virtual BugetAnt BugetAnt { get; set; }
        public virtual ArtBug ArtBug { get; set; }
    }
}