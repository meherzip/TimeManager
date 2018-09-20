namespace Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PeriodeJour")]
    public class PeriodeJour : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPeriodeJour { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        IList<JourTravaille> JourTravailles { get; set; }
    }
}
