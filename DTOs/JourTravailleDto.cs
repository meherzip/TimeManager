using System;

namespace DTOs
{
	public class JourTravailleDto : IDto
	{
		#region Properties
		public DateTime Date {get; set;}
		public Int32 IdBonCommande {get; set;}
		public Int32 IdEmployee {get; set;}
		public BonCommandeDto BonCommandeDto {get; set;}
		public EmployeeDto EmployeeDto {get; set;}
		public PeriodeJourDto PeriodeJourDto {get; set;}
		public System.Int32? NbrHeureSpecifique {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

