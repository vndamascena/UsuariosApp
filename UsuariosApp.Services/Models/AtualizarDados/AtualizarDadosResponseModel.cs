namespace UsuariosApp.Services.Models.AtualizarDados
{
    public class AtualizarDadosResponseModel
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public DateTime? DataHoraAtualizacao { get; set; }
    }
}
