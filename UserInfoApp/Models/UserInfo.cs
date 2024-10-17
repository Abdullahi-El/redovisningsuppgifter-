using System.ComponentModel.DataAnnotations;

namespace UserInfoApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty; // Initialize with an empty string

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty; // Initialize with an empty string
    }
}
