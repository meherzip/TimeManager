using System;

namespace DTOs
{
	public class SocieteDto : IDto
	{
		#region Properties
		public Int32 IdSociete {get; set;}
		public TypeSocieteDto TypeSocieteDto {get; set;}
		public String Nom {get; set;}
		public String Introduction {get; set;}
		public String Adresse {get; set;}
		public String CodePostal {get; set;}
		public String SiteWeb {get; set;}
		public String EMail {get; set;}
		public String TelephoneFixe {get; set;}
		public String TelephonePortable {get; set;}
		public String Fax {get; set;}
		public String Note {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

