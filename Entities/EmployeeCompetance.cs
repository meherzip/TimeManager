namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("EmployeeCompetance")]
    public class EmployeeCompetance : EntityBase
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Competance")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCompetance { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Employee")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmployee { get; set; }
        
        public Competance Competance { get; set; }
        public Employee Employee { get; set; }

        public int? Rating { get; set; }

        public int? NbrMois { get; set; }
    }
}
