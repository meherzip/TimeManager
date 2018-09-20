namespace Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("EtatDemandeConge")]
    public class EtatDemandeConge : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEtatDemandeConge { get; set; }
        
        public TypeEmployee TypeEmployee { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? Niveau { get; set; }

        public int? NiveauPrecedent { get; set; }

        public int? NiveauSuivant { get; set; }

        IList<PrioriteConge> PrioriteConges { get; set; }
        IList<EmployeeConge> EmployeeConges { get; set; }
    }
}
