using MediatR;
using VemDeZap.Domain.ValueObjects;

namespace VemDeZap.Domain.Commands.Usuario
{
    public class AdicionarUsuarioNotification 
        : INotification
    {
        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
    }
}
