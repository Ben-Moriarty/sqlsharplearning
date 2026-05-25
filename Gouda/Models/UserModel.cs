using System.ComponentModel.DataAnnotations;

namespace Gouda.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public required string UserName { get; set; }
    }
}
