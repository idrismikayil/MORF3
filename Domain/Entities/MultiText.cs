using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    /// <summary>
    /// Generic multi text class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MultiText<T> : BaseEntity where T : BaseEntity
    {
        [Required]
        [ForeignKey("Item")]
        public Guid ItemId { get; set; }
        [Required]
        public T Item { get; set; }
        [Required]
        public string Text { get; set; }
    }
}
