using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetManagement.Models
{
    public class SurseFin
    {
        [Key]
        [Column("srs_fin_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SrsFinId { get; set; }

        [Required]
        [Column("an")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short An { get; set; }

        [Required]
        [StringLength(10)]
        [Column("cod")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Cod { get; set; }

        [Required]
        [StringLength(50)]
        [Column("denumire")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Denumire { get; set; }

        [Required]
        [Column("colectie")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Colectie { get; set; }

        [Column("tipsrs")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public decimal TipSrs { get; set; } = 3;

        [Column("srs_fin_idp")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? SrsFinIdp { get; set; }

        [Required]
        [StringLength(10)]
        [Column("cod_afis")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CodAfis { get; set; }

        [Column("tipbuget")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public decimal TipBuget { get; set; } = 1;

        [Column("ordine")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Ordine { get; set; } = 1;

        [Column("sector_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? SectorId { get; set; }

        [Column("finantare_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? FinantareId { get; set; }

        [Column("blocat")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte Blocat { get; set; } = 0;
    }
}