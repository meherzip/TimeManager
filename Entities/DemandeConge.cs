namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DemandeConge")]
    public class DemandeConge : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDemandeConge { get; set; }
        
        public Employee Employee { get; set; }

        public PrioriteConge PrioriteConge { get; set; }

        public TypeConge TypeConge { get; set; }

        public DateTime? DateDebut { get; set; }

        public DateTime? DateFin { get; set; }

        [StringLength(200)]
        public string Demande { get; set; }

        [StringLength(200)]
        public string Raison { get; set; }

        IList<EtatDemandeConge> EtatDemandeConges { get; set; }
        IList<EmployeeConge> EmployeeConges { get; set; }
    }
}
