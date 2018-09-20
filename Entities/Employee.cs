namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Employee")]
    public class Employee : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmployee { get; set; }
        
        public Employee Responsable { get; set; }

        public TypeEmployee TypeEmployee { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(50)]
        public string Prenom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateNaissance { get; set; }

        [StringLength(200)]
        public string Adresse { get; set; }

        [StringLength(10)]
        public string CodePostal { get; set; }

        [StringLength(50)]
        public string EMail { get; set; }

        [StringLength(20)]
        public string TelephonePortable { get; set; }

        [StringLength(20)]
        public string TelephoneFixe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateDebut { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateFin { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        IList<BonCommandeEmployee> BonCommandeEmployees { get; set; }
        IList<DemandeConge> DemandeConges { get; set; }
        IList<EmployeeCompetance> EmployeeCompetances { get; set; }
        IList<EmployeeTypePrime> EmployeeTypePrimes { get; set; }
        IList<Frai> Frais { get; set; }
        IList<JourTravaille> JourTravailles { get; set; }
        IList<Salaire> Salaires { get; set; }
        IList<ValidationCRA> ValidationCRAs { get; set; }
        IList<EmployeeConge> EmployeeConges { get; set; }
    }
}
