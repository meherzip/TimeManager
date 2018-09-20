namespace Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ValidationCRA")]
    public class ValidationCRA : EntityBase
    {
        [Key]
        public int IdValidationCRA { get; set; }
        
        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public BonCommande BonCommande { get; set; }

        public Employee Employee { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateValidation { get; set; }

        public bool? Validation { get; set; }
    }
}
