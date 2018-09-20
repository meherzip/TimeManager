namespace Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TypeCompetance")]
    public class TypeCompetance : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTypeCompetance { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}
