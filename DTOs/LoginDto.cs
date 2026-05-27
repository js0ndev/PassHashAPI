using System.ComponentModel.DataAnnotations;

namespace RegistroSeguroAPI.DTOs
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email {get; set;} = string.Empty;

        [Required]
        public string SenhaHash {get; set;} = string.Empty;
    }
}