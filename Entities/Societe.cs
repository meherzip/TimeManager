namespace Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Societe")]
    public class Societe : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSociete { get; set; }
        
        public TypeSociete TypeSociete { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(200)]
        public string Introduction { get; set; }

        [StringLength(200)]
        public string Adresse { get; set; }

        [StringLength(10)]
        public string CodePostal { get; set; }

        [StringLength(50)]
        public string SiteWeb { get; set; }

        [StringLength(50)]
        public string EMail { get; set; }

        [StringLength(20)]
        public string TelephoneFixe { get; set; }

        [StringLength(20)]
        public string TelephonePortable { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        IList<Contrat> Contrats { get; set; }
        IList<Contact> Contacts { get; set; }
    }
}
