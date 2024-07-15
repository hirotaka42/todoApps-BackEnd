﻿using System;
namespace todo_backend.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string ?Title { get; set; }
        public string ?Description { get; set; }
        public bool IsDone { get; set; }
        public string UserId { get; set; }
    }

}

