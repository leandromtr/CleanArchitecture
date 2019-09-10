using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Core.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infra.Bus
{
    public sealed class InMemoryBus: IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            mediator = _mediator;
        }

        public Task SendCommand<T>(T command) where T: Command
        {
            return _mediator.Send(command);
        }
    }
}
