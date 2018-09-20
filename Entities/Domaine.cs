namespace Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Domaine")]
    public class Domaine : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDomaine { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        IList<GrilleSalaire> GrilleSalaires { get; set; }
        IList<Competance> Competances { get; set; }
    }
}
