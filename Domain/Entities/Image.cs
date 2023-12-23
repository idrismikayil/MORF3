using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    /// <summary>
    /// Generic image class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Image<T> : BaseEntity where T : BaseEntity
    {
        [Required]
        [ForeignKey("Item")]
        public Guid ItemId { get; set; }
        [Required]
        public T Item { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}