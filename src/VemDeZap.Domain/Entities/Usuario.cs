using VemDeZap.Domain.Entities.Base;
using VemDeZap.Domain.ValueObjects;

namespace VemDeZap.Domain.Entities
{
    public class Usuario : Entity
    {
        public Usuario(Nome nome,
            Email email,
            string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }
    }
}
