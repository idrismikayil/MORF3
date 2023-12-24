using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Partner : BaseEntity
    {
        [Required]
        [StringLength(1000)]
        public string Link{ get; set; }
        [Required]
        [StringLength(1000)]
        public string ImageTitle { get; set; }
    }
}
