using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models.DTOs.Respones
{
    public class UserLoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}