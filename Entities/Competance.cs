namespace Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Competance")]
    public class Competance : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCompetance { get; set; }

        public TypeCompetance TypeCompetance { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        IList<EmployeeCompetance> EmployeeCompetances { get; set; }
        IList<GrilleSalaire> GrilleSalaires { get; set; }
        IList<Domaine> Domaines { get; set; }
    }
}
