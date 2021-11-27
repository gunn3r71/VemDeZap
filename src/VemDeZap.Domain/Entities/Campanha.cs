using System;
using VemDeZap.Domain.Entities.Base;

namespace VemDeZap.Domain.Entities
{
    public class Campanha : Entity
    {
        public Campanha(string nome, Guid usuarioId)
        {
            Nome = nome;
            UsuarioId = usuarioId;
        }

        public string Nome { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }
    }
}
