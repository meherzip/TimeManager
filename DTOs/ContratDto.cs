using System;

namespace DTOs
{
	public class ContratDto : IDto
	{
		#region Properties
		public Int32 IdContrat {get; set;}
		public ContactDto ContactDto {get; set;}
		public SocieteDto SocieteDto {get; set;}
		public String CodeContrat {get; set;}
		public System.DateTime? DateDebut {get; set;}
		public System.DateTime? DateFin {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

