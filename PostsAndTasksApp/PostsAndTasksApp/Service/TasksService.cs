using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostsAndTasksApp.Utils;
using PostsAndTasksConsoleApp;
using PostsAndTasksConsoleApp.Repository;

namespace PostsAndTasksApp.Service
{
    public class TasksService : ICustomObservable<Task>
    {
        private List<ICustomObserver<Task>> _observers = new List<ICustomObserver<Task>>();
        private AbstratRepository<int, Task> _repo;

        public TasksService(AbstratRepository<int, Task> repo)
        {
            _repo = repo;
        }

        public void RegistrateObs(ICustomObserver<Task> ob)
        {
            AddObserver(ob);
        }

        public List<Task> GetAll()
        {
            return (List<Task>)_repo.GetAll();
        }

        public void Add(Task t)
        {
            _repo.Add(t);
            NotifyObservers();
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
            NotifyObservers();
        }


        public void Update(Task t)
        {
            _repo.Update(t);
            NotifyObservers();
        }

        public void AddObserver(ICustomObserver<Task> o)
        {
            _observers.Add(o);
        }

        public void DeleteObserver(ICustomObserver<Task> o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var o in _observers)
            {
                o.Update(GetAll());
            }
        }
    }
}
