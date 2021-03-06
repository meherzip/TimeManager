 
 
using System;

namespace DTOs
{
	public class BonCommandeDto : IDto
	{
		#region Properties
		public Int32 IdBonCommande {get; set;}
		public ContratDto ContratDto {get; set;}
		public EtatBonCommandeDto EtatBonCommandeDto {get; set;}
		public ContactDto ContactDto {get; set;}
		public String Nom {get; set;}
		public String Description {get; set;}
		public System.DateTime? DateDebut {get; set;}
		public System.DateTime? DateFin {get; set;}
		public String Note {get; set;}
		public System.Double? MargePrevue {get; set;}
		public System.Double? MargeReel {get; set;}
		public EmployeeDto UserInsert {get; set;}
		public DateTime DateInsert {get; set;}
		public EmployeeDto UserUpdate {get; set;}
		public DateTime DateUpdate {get; set;}
		#endregion Properties
	}

}

