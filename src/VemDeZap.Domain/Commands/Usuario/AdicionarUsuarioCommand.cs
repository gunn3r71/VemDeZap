using MediatR;
using VemDeZap.Domain.ValueObjects;

namespace VemDeZap.Domain.Commands.Usuario
{
    public class AdicionarUsuarioCommand
        : IRequest<Response>
    {
        public AdicionarUsuarioCommand(Nome nome,
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
