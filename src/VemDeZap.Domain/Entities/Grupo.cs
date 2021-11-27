using System;
using VemDeZap.Domain.Entities.Base;
using VemDeZap.Domain.Enums;

namespace VemDeZap.Domain.Entities
{
    public class Grupo : Entity
    {
        public Grupo(string nome,
            EnumNicho nicho,
            Guid usuarioId)
        {
            Nome = nome;
            Nicho = nicho;
            UsuarioId = usuarioId;
        }

        public string Nome { get; private set; }
        public EnumNicho Nicho { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }
    }
}
