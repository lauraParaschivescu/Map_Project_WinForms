using System.Collections.Generic;
using PostsAndTasksApp.Service;
using PostsAndTasksApp.Utils;
using PostsAndTasksConsoleApp;
using PostsAndTasksConsoleApp.Domain;

namespace PostsAndTasksApp.Controller
{
    public class TasksController
    {
        private IValidator<Task> _val;
        private TasksService _service;

        public TasksController(IValidator<Task> val, TasksService service)
        {
            _val = val;
            _service = service;
        }

        public void RegistrateObs(ICustomObserver<Task> ob)
        {
            _service.RegistrateObs(ob);
        }

        public void Add(int id, string description, int duration)
        {
            Task t = new Task()
            {
                Id = id,
                Description = description,
                Duration = duration
            };
            _val.Validate(t);
            _service.Add(t);
        }

        public List<Task> GetAll()
        {
            return _service.GetAll();
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }

        public void Update(int id, string description, int duration)
        {
            Task t = new Task()
            {
                Id = id,
                Description = description,
                Duration = duration
            };
            _val.Validate(t);
            _service.Update(t);
        }
    }
}
