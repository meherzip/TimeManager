namespace Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TypeEmployee")]
    public class TypeEmployee : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTypeEmployee { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        IList<Employee> Employees { get; set; }
        IList<EtatDemandeConge> EtatDemandeConges { get; set; }
    }
}
