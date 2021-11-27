using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace VemDeZap.Domain.Commands.Usuario
{
    public class AdicionarUsuarioCommandHandler
        : IRequestHandler<AdicionarUsuarioCommand, Response>
    {
        public async Task<Response> Handle(AdicionarUsuarioCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
