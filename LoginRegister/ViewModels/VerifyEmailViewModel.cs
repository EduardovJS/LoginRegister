using System.ComponentModel.DataAnnotations;

namespace LoginRegister.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Seu email é obrigatório.")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
