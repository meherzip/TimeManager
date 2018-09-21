using System;

namespace DTOs
{
	public class ValidationCRADto : IDto
	{
		#region Properties
		public Int32 IdValidationCRA {get; set;}
		public System.DateTime? Date {get; set;}
		public BonCommandeDto BonCommandeDto {get; set;}
		public EmployeeDto EmployeeDto {get; set;}
		public System.DateTime? DateValidation {get; set;}
		public System.Boolean? Validation {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

