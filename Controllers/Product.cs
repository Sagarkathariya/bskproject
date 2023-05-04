using System.ComponentModel.DataAnnotations;

namespace bskproject.Controllers
{
    public class Product
    {
        public int? Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? ProductName { get; set; }
        [Required]
        public decimal? price { get; set; }
        [Required]
        public int? Qty { get; set; }
    }
}
