using System;

namespace DTOs
{
	public class TypeEmployeeDto : IDto
	{
		#region Properties
		public Int32 IdTypeEmployee {get; set;}
		public String Nom {get; set;}
		public String Description {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

