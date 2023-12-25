using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Home
{
    public class Address : BaseEntity
    {
        [Required]
        [StringLength(500)]
        public string Text { get; set; }
        [Required]
        [StringLength(500)]
        public string Number { get; set; }
    }
}
