using ToDoApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToDoApp.Services
{
    public class TaskService
    {
        private static List<TaskItem> _tasks = new List<TaskItem>();
        private static int _nextId = 1;

        public List<TaskItem> GetTasks() => _tasks;

        public void AddTask(string title)
        {
            _tasks.Add(new TaskItem { Id = _nextId++, Title = title });
        }

        public void MarkTaskAsCompleted(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null) task.IsCompleted = true;
        }

        public void DeleteTask(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null) _tasks.Remove(task);
        }
    }
}
