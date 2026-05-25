using System.ComponentModel.DataAnnotations;

namespace Gouda.Models
{
    public class EventModel
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [MaxLength(50)]
        public required string EventName { get; set; }
    }
}