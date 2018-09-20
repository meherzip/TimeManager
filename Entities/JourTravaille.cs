namespace Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("JourTravaille")]
    public class JourTravaille : EntityBase
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        [ForeignKey("")]
        public DateTime Date { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("BonCommande")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdBonCommande { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Employee")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmployee { get; set; }
        
        public BonCommande BonCommande { get; set; }
        public Employee Employee { get; set; }

        public PeriodeJour PeriodeJour { get; set; }

        public int? NbrHeureSpecifique { get; set; }
    }
}
