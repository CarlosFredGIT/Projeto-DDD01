using MediatR;
using Projeto01.Application.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Application.Handlers
{
    public class FuncionarioHandler : INotificationHandler<FuncionarioNotification>
    {
        public Task Handle(FuncionarioNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
