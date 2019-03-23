using Dotnetcorewebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnetcorewebapi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TodoContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.TodoItems.Any())
            {
                return;   // DB has been seeded
            }

            var todoItems = new TodoItem[]
            {           
                new TodoItem{Name="Norman",IsComplete = true},
                new TodoItem{Name="Olivetto",IsComplete = false}
            };
            foreach (TodoItem t in todoItems)
            {
                context.TodoItems.Add(t);
            }
            context.SaveChanges();


        }
    }
}
