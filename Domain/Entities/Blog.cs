using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Blog : BaseEntity
    {
        [Required]
        [MaxLength(500)]
        public string Title { get; set; }
        [Required]
        public MultiText<Blog> Texts { get; set; }
        [Required]
        public Image<Blog> Images { get; set; }
    }
}
