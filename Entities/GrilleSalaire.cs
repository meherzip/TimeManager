namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("GrilleSalaire")]
    public class GrilleSalaire : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdGrilleSalaire { get; set; }
        
        public Competance Competance { get; set; }

        public Domaine Domaine { get; set; }

        public int? NbrAnneeDebut { get; set; }

        public int? NbrAnneeFin { get; set; }

        public double? ValeurMin { get; set; }

        public double? ValeurMax { get; set; }
    }
}
