using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class SocialMedia : BaseEntity
    {
        [Required]
        [StringLength(200)]
        public string Facebook { get; set; }
        [Required]
        [StringLength(200)]
        public string Instagram { get; set; }
        [Required]
        [StringLength(200)]
        public string Twitter { get; set; }
    }
}