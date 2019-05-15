using System;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Infrastructure
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) :
            base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }

    }
}
