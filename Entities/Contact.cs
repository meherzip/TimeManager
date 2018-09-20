namespace Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Contact")]
    public class Contact : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdContact { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(50)]
        public string Prenom { get; set; }

        [StringLength(200)]
        public string Adresse { get; set; }

        [StringLength(10)]
        public string CodePostal { get; set; }

        [StringLength(20)]
        public string TelephoneFixe { get; set; }

        [StringLength(20)]
        public string TelephonePortable { get; set; }

        [StringLength(50)]
        public string EMail { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Poste { get; set; }

        IList<BonCommande> BonCommandes { get; set; }
        IList<Contrat> Contrats { get; set; }
        IList<Societe> Societes { get; set; }
    }
}
