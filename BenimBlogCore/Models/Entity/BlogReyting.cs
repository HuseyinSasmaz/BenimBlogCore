
using System.ComponentModel.DataAnnotations;
namespace BenimBlogCore.Models.Entity
{
    public class BlogReyting
    {
        [Key]
        public int BlogReytinID { get; set; }

        public int BlogID { get; set; }

        public int BlogToplamSkoru { get; set; }

        public int BlogReytingSayısı { get; set; }
    }
}
