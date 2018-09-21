using System;

namespace DTOs
{
	public class DemandeCongeDto : IDto
	{
		#region Properties
		public Int32 IdDemandeConge {get; set;}
		public EmployeeDto EmployeeDto {get; set;}
		public PrioriteCongeDto PrioriteCongeDto {get; set;}
		public TypeCongeDto TypeCongeDto {get; set;}
		public System.DateTime? DateDebut {get; set;}
		public System.DateTime? DateFin {get; set;}
		public String Demande {get; set;}
		public String Raison {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

