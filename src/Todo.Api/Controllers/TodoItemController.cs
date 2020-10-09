using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.TodoItems.Commands.CreateTodoItemCommand;
using Microsoft.AspNetCore.Mvc;

namespace Todo.Api.Controllers
{
    [Route("[controller]")]
    public class TodoItemController : ApiController
    {
        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<int>> Create(CreateTodoItemCommand command)
        {
            throw  new Exception();
            return await Mediator.Send(command);
        }
    }
}
