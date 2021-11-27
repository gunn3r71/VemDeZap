using System;
using VemDeZap.Domain.Entities.Base;
using VemDeZap.Domain.Enums;
using VemDeZap.Domain.ValueObjects;

namespace VemDeZap.Domain.Entities
{
    public class Contato : Entity
    {
        public Contato(string nome,
            Telefone telefone,
            EnumNicho nicho, 
            Guid usuarioId)
        {
            Nome = nome;
            Telefone = telefone;
            Nicho = nicho;
            UsuarioId = usuarioId;
        }

        public string Nome { get; private set; }
        public Telefone Telefone { get; private set; }
        public EnumNicho Nicho { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }
    }
}
