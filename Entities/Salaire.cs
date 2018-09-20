namespace Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Salaire")]
    public class Salaire : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSalaire { get; set; }
        
        public Employee Employee { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateDebut { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateFin { get; set; }

        public double? Valeur { get; set; }

        [StringLength(200)]
        public string Note { get; set; }
    }
}
