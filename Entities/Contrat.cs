namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Contrat")]
    public class Contrat : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdContrat { get; set; }

        public Contact Contact { get; set; }

        public Societe Societe { get; set; }

        [StringLength(50)]
        public string CodeContrat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateDebut { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateFin { get; set; }

        IList<BonCommande> BonCommandes { get; set; }
    }
}
