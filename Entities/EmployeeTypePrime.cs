namespace Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("EmployeeTypePrime")]
    public class EmployeeTypePrime : EntityBase
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("TypePrime")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTypePrime { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Employee")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmployee { get; set; }
        
        public TypePrime TypePrime { get; set; }
        public Employee Employee { get; set; }

        public double? Valeur { get; set; }

        [StringLength(200)]
        public string Note { get; set; }
    }
}
