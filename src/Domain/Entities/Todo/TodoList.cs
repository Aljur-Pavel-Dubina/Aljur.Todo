using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities.Todo
{
    public class TodoList: AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Colour { get; set; }

        public IList<TodoItem> Items { get; set; }
    }
}
