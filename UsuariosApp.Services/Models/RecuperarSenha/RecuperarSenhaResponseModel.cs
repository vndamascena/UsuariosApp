﻿namespace UsuariosApp.Services.Models.RecuperarSenha
{
    public class RecuperarSenhaResponseModel
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public DateTime? DataHoraRecuperacaoDeSenha { get; set; }

    }
}
