using System;

namespace DTOs
{
	public class BonCommandeEmployeeDto : IDto
	{
		#region Properties
		public Int32 IdBonCommande {get; set;}
		public Int32 IdEmployee {get; set;}
		public BonCommandeDto BonCommandeDto {get; set;}
		public EmployeeDto EmployeeDto {get; set;}
		public System.DateTime? DateSelection {get; set;}
		public String Note {get; set;}
		public System.Int32? Rating {get; set;}
		public System.Boolean? Impose {get; set;}
		public System.Boolean? Confirmer {get; set;}
		public System.Double? MargePrevue {get; set;}
		public System.Double? MargeReel {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

