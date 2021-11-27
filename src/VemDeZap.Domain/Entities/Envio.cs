using System;
using VemDeZap.Domain.Entities.Base;

namespace VemDeZap.Domain.Entities
{
    public class Envio : Entity
    {
        public Envio(Guid campanhaId, 
            Guid grupoId,
            Guid contatoId, 
            bool enviado)
        {
            CampanhaId = campanhaId;
            GrupoId = grupoId;
            ContatoId = contatoId;
            Enviado = enviado;
        }

        public Guid CampanhaId { get; private set; }
        public Guid GrupoId { get; private set; }
        public Guid ContatoId { get; private set; }
        public bool Enviado { get; private set; }

        public Campanha Campanha { get; private set; }
        public Grupo Grupo { get; private set; }
        public Contato Contato { get; private set; }
    }
}
