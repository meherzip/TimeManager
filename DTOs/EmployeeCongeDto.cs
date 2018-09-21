using System;

namespace DTOs
{
	public class EmployeeCongeDto : IDto
	{
		#region Properties
		public Int32 IdDemandeConge {get; set;}
		public Int32 IdEtatDemandeConge {get; set;}
		public Int32 IdEmployee {get; set;}
		public DemandeCongeDto DemandeCongeDto {get; set;}
		public EtatDemandeCongeDto EtatDemandeCongeDto {get; set;}
		public EmployeeDto EmployeeDto {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

