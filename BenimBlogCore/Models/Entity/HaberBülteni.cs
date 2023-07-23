using System.ComponentModel.DataAnnotations;

namespace BenimBlogCore.Models.Entity
{
	public class HaberBulteni
	{
		[Key]
		public int MailID { get; set; }
		public string Mail { get; set; }
		public bool MailStatu { get; set; }
	}
}
