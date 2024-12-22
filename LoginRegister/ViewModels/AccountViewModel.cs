using System.ComponentModel.DataAnnotations;


namespace LoginRegister.ViewModels
{
    public class AccountViewModel
    {

        [Required(ErrorMessage = "Informe seu nome de usuário")]
        [Display(Name= "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe o seu email de login")]
        [Display(Name= "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe sua senha de login")]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }






    }
}
