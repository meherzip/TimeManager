using System;

namespace DTOs
{
	public class SalaireDto : IDto
	{
		#region Properties
		public Int32 IdSalaire {get; set;}
		public EmployeeDto EmployeeDto {get; set;}
		public System.DateTime? DateDebut {get; set;}
		public System.DateTime? DateFin {get; set;}
		public System.Double? Valeur {get; set;}
		public String Note {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

