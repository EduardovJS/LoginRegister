using System.ComponentModel.DataAnnotations;

namespace LoginRegister.ViewModels
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Seu nome é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Seu email é obrigatório.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Sua senha é obrigatória")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage ="Suas senhas tem que ser iguais.")]
        [Display(Name = "Nova Senha")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Sua confirmação de senha é obrigatória")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme sua senha")]
        public string ConfirmPassword { get; set; }


    }
}
