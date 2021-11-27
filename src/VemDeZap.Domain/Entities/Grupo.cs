using System;
using VemDeZap.Domain.Entities.Base;

namespace VemDeZap.Domain.Entities
{
    public class Grupo : Entity
    {
        public Grupo(string nome, 
            int nicho,
            Guid usuarioId)
        {
            Nome = nome;
            Nicho = nicho;
            UsuarioId = usuarioId;
        }

        public string Nome { get; private set; }
        public int Nicho { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }
    }
}
