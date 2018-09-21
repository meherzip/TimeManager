using System;

namespace DTOs
{
	public class EmployeeCompetanceDto : IDto
	{
		#region Properties
		public Int32 IdCompetance {get; set;}
		public Int32 IdEmployee {get; set;}
		public CompetanceDto CompetanceDto {get; set;}
		public EmployeeDto EmployeeDto {get; set;}
		public System.Int32? Rating {get; set;}
		public System.Int32? NbrMois {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

