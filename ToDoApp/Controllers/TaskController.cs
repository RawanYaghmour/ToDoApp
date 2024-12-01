using Microsoft.AspNetCore.Mvc;
using ToDoApp.Services;

namespace ToDoApp.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskService _taskService;

        public TaskController(TaskService taskService)
        {
            _taskService = taskService;
        }

        public IActionResult Index()
        {
            var tasks = _taskService.GetTasks();
            return View(tasks);
        }

        [HttpPost]
        public IActionResult AddTask(string title)
        {
            if (!string.IsNullOrEmpty(title))
            {
                _taskService.AddTask(title);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult MarkAsCompleted(int id)
        {
            _taskService.MarkTaskAsCompleted(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteTask(int id)
        {
            _taskService.DeleteTask(id);
            return RedirectToAction("Index");
        }
    }
}
