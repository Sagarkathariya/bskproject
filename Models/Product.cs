using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bskproject.Models
{
    public class Product
    {
        public int? Id { get; set; }
        [Required(ErrorMessage ="Required")]
        [MaxLength(50)]
        public string? ProductName { get; set; }
        [Required(ErrorMessage ="Required")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Required")]
        public int? Qty { get; set; }

        [Required(ErrorMessage = "Required")]
        public string? Remarks { get; set; }
    }
}
