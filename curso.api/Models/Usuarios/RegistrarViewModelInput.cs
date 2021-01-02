using System.ComponentModel.DataAnnotations;

namespace curso.api.Models.Usuarios
{
    public class RegistrarViewModelInput
    {
        [Required(ErrorMessage = "Login é Obrigatório")]
        public string Login { get; set; }
        [Required(ErrorMessage ="Email Obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha é Obrigatória")]
        public string Senha { get; set; }

    }
}
