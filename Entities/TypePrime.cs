namespace Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TypePrime")]
    public class TypePrime : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTypePrime { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(200)]
        public string Condition { get; set; }

        public double? ValeurParDefaut { get; set; }

        IList<EmployeeTypePrime> EmployeeTypePrimes { get; set; }
    }
}
