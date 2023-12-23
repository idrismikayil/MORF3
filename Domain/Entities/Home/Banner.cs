using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Home
{
    public class Banner : BaseEntity
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        public string SubTitle { get; set; }
        [Required]
        [StringLength(1000)]
        public string Link { get; set; }
        [Required]
        [StringLength(1000)]
        public string Image { get; set; }
    }
}
