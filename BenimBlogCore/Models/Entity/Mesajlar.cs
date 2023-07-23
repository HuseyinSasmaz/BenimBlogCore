

using System.ComponentModel.DataAnnotations;

namespace BenimBlogCore.Models.Entity
{
	public class Mesajlar
	{
		[Key]
		public int MesajID  { get; set; }
		public string Gönderen { get;set; }
		public string Alan { get; set; }
		public string MesajBaslık { get; set; }	
		public string MesajDetay { get; set; }
		public DateTime MesajTarihi { get; set; }	
		public bool MesajStatu { get; set; }
	}
}
