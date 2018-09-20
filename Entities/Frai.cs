namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Frai : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFrais { get; set; }
        
        public TypeFrai TypeFrai { get; set; }

        public BonCommande BonCommande { get; set; }

        public Employee Employee { get; set; }

        public double? Valeur { get; set; }

        public bool? Valide { get; set; }

        [StringLength(200)]
        public string Note { get; set; }
    }
}
