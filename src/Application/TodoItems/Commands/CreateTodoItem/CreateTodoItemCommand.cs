using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Application.TodoItems.Commands.CreateTodoItemCommand
{
    public class CreateTodoItemCommand : IRequest<int>
    {

        public string Title { get; set; }

        public string Note { get; set; }
    }

    public class CreateTodoItemCommandHandler : IRequestHandler<CreateTodoItemCommand, int>
    {
        public async Task<int> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
        {
            return  new Random().Next(0,99999);
        }
    }
}
