using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace server.Controllers
{
    public class ProductDetail
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string ProductName { get; set; } = "";
        public float Price { get; set; }
        public string Description { get; set; } = "";
    }
}
