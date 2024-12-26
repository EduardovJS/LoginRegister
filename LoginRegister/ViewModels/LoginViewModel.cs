using System.ComponentModel.DataAnnotations;

namespace LoginRegister.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Digite seu email.")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "Digite sua senha.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Lembrar-se")]
        public bool RememberMe { get; set; }
    }
}
