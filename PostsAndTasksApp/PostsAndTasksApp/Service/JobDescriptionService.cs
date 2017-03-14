using System.Collections.Generic;
using PostsAndTasksApp.Domain;
using PostsAndTasksApp.Repository;
using PostsAndTasksApp.Utils;
using PostsAndTasksConsoleApp;
using Task = PostsAndTasksConsoleApp.Task;

namespace PostsAndTasksApp.Service
{
    public class JobDescriptionService : ICustomObservable<JobDescription>
    {
        private PostsService _postsService;
        private TasksService _tasksService;
        private JobDescriptionRepository _repoJobDescription;
        private List<ICustomObserver<JobDescription>> _observers = new List<ICustomObserver<JobDescription>>();

        public JobDescriptionService(PostsService postsService, TasksService tasksService, JobDescriptionRepository repoJobDescription)
        {
            _postsService = postsService;
            _tasksService = tasksService;
            _repoJobDescription = repoJobDescription;
        }

        public void RegistrateObs(ICustomObserver<JobDescription> ob)
        {
            AddObserver(ob);
        }

        public List<Post> GetAllPosts()
        {
            return _postsService.GetAll();
        }

        public List<Task> GetAllTasks()
        {
            return _tasksService.GetAll();
        }

        public List<JobDescription> GetAll()
        {
            return (List<JobDescription>)_repoJobDescription.GetAll();
        }

        public void Add(JobDescription p)
        {
            _repoJobDescription.Add(p);
            NotifyObservers();
        }

        public void Delete(string p)
        {
            _repoJobDescription.Delete(p);
            NotifyObservers();
        }

        public void AddObserver(ICustomObserver<JobDescription> o)
        {
            _observers.Add(o);
        }

        public void DeleteObserver(ICustomObserver<JobDescription> o)
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
