using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using todo_backend.Models;

namespace todo_backend.Contexts
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }
    }

}

