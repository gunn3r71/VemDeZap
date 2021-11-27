using prmToolkit.NotificationPattern;
using System.Collections.Generic;

namespace VemDeZap.Domain.Commands
{
    public class Response
    {
        public Response(INotifiable notifiable)
        {
            Sucesso = notifiable.IsValid();
            Notificacoes = notifiable.Notifications;
        }

        public Response(INotifiable notifiable, object data)
            : this(notifiable)
        {
            Data = data;
        }

        public bool Sucesso { get; private set; }
        public object Data { get; private set; }

        public IEnumerable<Notification> Notificacoes { get; private set; }
    }
}
