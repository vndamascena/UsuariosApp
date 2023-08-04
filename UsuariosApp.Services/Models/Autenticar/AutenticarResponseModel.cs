namespace UsuariosApp.Services.Models.Autenticar
{
    public class AutenticarResponseModel
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? AcessToken { get; set; }
        public DateTime? DataHoraAcesso { get; set; }
        public DateTime? DataHoraExpiracao { get; set; }
    }

}

