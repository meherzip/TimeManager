using System;

namespace DTOs
{
	public class EmployeeTypePrimeDto : IDto
	{
		#region Properties
		public Int32 IdTypePrime {get; set;}
		public Int32 IdEmployee {get; set;}
		public TypePrimeDto TypePrimeDto {get; set;}
		public EmployeeDto EmployeeDto {get; set;}
		public System.Double? Valeur {get; set;}
		public String Note {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

