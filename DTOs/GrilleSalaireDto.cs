using System;

namespace DTOs
{
	public class GrilleSalaireDto : IDto
	{
		#region Properties
		public Int32 IdGrilleSalaire {get; set;}
		public CompetanceDto CompetanceDto {get; set;}
		public DomaineDto DomaineDto {get; set;}
		public System.Int32? NbrAnneeDebut {get; set;}
		public System.Int32? NbrAnneeFin {get; set;}
		public System.Double? ValeurMin {get; set;}
		public System.Double? ValeurMax {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

