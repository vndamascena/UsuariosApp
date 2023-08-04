using System.ComponentModel.DataAnnotations;

namespace UsuariosApp.Services.Models.RecuperarSenha
{
    public class RecuperarSenhaRequestModel
    {
        [EmailAddress(ErrorMessage = "Informe um endereço de email válido.")]
        [Required(ErrorMessage = "Por favor, informe o email do usuário.")]
        public string? Email { get; set; }
    }
}
