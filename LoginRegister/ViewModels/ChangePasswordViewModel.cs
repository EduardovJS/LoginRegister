using System.ComponentModel.DataAnnotations;

namespace LoginRegister.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Seu email é obrigatório.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Sua senha é obrigatória")]
        [DataType(DataType.Password)]
        [Compare("ConfirmNewPassword", ErrorMessage = "As duas senhas devem     ser iguais.")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Sua confirmação de senha é obrigatória")]
        [DataType(DataType.Password)]
        [Display(Name = "Confime sua nova senha")]
        public string ConfirmNewPassword { get; set; }



    }
}
