namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("EmployeeConge")]
    public class EmployeeConge : EntityBase
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("DemandeConge")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDemandeConge { get; set; }
        
        [Key]
        [Column(Order = 1)]
        [ForeignKey("EtatDemandeConge")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEtatDemandeConge { get; set; }
        

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Employee")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int IdEmployee { get; set; }
        public DemandeConge DemandeConge { get; set; }
        public EtatDemandeConge EtatDemandeConge { get; set; }
        public Employee Employee { get; set; }
    }
}
