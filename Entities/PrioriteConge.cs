namespace Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PrioriteConge")]
    public class PrioriteConge : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPrioriteConge { get; set; }
        
        public EtatDemandeConge EtatDemandeConge { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? DelaiRetourMax { get; set; }

        IList<DemandeConge> DemandeConges { get; set; }
    }
}
