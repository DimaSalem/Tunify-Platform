using System.ComponentModel.DataAnnotations;

namespace Tunify_Platform.Models.DTO
{
    public class RegisterDto
    {
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public IList<string> Roles { get; set; }
    }
}
