using System.ComponentModel.DataAnnotations;

namespace Traversal.Models
{
    public class UserSigInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adınızı Giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }

    }
}
