using System.ComponentModel.DataAnnotations;

namespace YalcomaniaToursMkfMtr.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-Mail girmeniz gerekmektedir!")]
        [Display(Name = "E-Mail")]
        public string UserMail { get; set; }
        [Required(ErrorMessage = "Şifre girmeniz gerekmektedir!")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}
