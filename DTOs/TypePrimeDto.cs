using System;

namespace DTOs
{
	public class TypePrimeDto : IDto
	{
		#region Properties
		public Int32 IdTypePrime {get; set;}
		public String Nom {get; set;}
		public String Description {get; set;}
		public String Condition {get; set;}
		public System.Double? ValeurParDefaut {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

