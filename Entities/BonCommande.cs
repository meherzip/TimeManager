namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BonCommande")]
    public class BonCommande: EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdBonCommande { get; set; }

        public Contrat Contrat { get; set; }

        public EtatBonCommande EtatBonCommande { get; set; }

        public Contact Contact { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateDebut { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateFin { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public double? MargePrevue { get; set; }

        public double? MargeReel { get; set; }

        IList<BonCommandeEmployee> BonCommandeEmployees { get; set; }
        IList<Frai> Frais { get; set; }
        IList<JourTravaille> JourTravailles { get; set; }
        IList<ValidationCRA> ValidationCRAs { get; set; }
    }
}
