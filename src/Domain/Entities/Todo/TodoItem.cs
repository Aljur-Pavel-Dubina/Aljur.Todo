﻿using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities.Todo
{
    public class TodoItem : AuditableEntity
    {
        public int Id { get; set; }
        public TodoList List { get; set; }

        public int ListId { get; set; }

        public string Title { get; set; }

        public string Note { get; set; }
    }
}
