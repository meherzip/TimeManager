using System;

namespace DTOs
{
	public class FraiDto : IDto
	{
		#region Properties
		public Int32 IdFrais {get; set;}
		public TypeFraiDto TypeFraiDto {get; set;}
		public BonCommandeDto BonCommandeDto {get; set;}
		public EmployeeDto EmployeeDto {get; set;}
		public System.Double? Valeur {get; set;}
		public System.Boolean? Valide {get; set;}
		public String Note {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

