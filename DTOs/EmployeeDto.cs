using System;

namespace DTOs
{
	public class EmployeeDto : IDto
	{
		#region Properties
		public Int32 IdEmployee {get; set;}
		public EmployeeDto ResponsableDto {get; set;}
		public TypeEmployeeDto TypeEmployeeDto {get; set;}
		public String Nom {get; set;}
		public String Prenom {get; set;}
		public System.DateTime? DateNaissance {get; set;}
		public String Adresse {get; set;}
		public String CodePostal {get; set;}
		public String EMail {get; set;}
		public String TelephonePortable {get; set;}
		public String TelephoneFixe {get; set;}
		public System.DateTime? DateDebut {get; set;}
		public System.DateTime? DateFin {get; set;}
		public String Note {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

