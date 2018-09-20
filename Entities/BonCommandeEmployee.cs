namespace Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BonCommandeEmployee")]
    public class BonCommandeEmployee : EntityBase
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("BonCommande")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdBonCommande { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Employee")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEmployee { get; set; }

        public BonCommande BonCommande { get; set; }
        public Employee Employee { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateSelection { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public int? Rating { get; set; }

        public bool? Impose { get; set; }

        public bool? Confirmer { get; set; }

        public double? MargePrevue { get; set; }

        public double? MargeReel { get; set; }
    }
}
