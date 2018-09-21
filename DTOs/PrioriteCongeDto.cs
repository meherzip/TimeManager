using System;

namespace DTOs
{
	public class PrioriteCongeDto : IDto
	{
		#region Properties
		public Int32 IdPrioriteConge {get; set;}
		public EtatDemandeCongeDto EtatDemandeCongeDto {get; set;}
		public String Nom {get; set;}
		public String Description {get; set;}
		public System.Int32? DelaiRetourMax {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

