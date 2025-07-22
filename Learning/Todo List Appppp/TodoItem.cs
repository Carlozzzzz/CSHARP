using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_Appppp
{
    internal class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedAt { get; set; }

        public TodoItem(string title, string description, bool isCompleted)
        {
            Title = title;
            Description = description;
            IsCompleted = isCompleted;
            CreatedAt = DateTime.Now;
        }

        public override string ToString()
        {
            return $"ID: {Id} Title: {Title}, Description: {Description}, Completed: {IsCompleted}, Date: {CreatedAt:MM/dd/yyyy hh:mm tt}";
        }
    }
}
