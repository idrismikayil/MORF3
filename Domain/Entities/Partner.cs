using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Partner : BaseEntity
    {
        [Required]
        public string Link{ get; set; }
    }
}
