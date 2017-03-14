using System.Collections.Generic;
using PostsAndTasksApp.Utils;
using PostsAndTasksConsoleApp;
using PostsAndTasksConsoleApp.Repository;

namespace PostsAndTasksApp.Service
{
    public class PostsService : ICustomObservable<Post>
    {
        private List<ICustomObserver<Post>> _observers = new List<ICustomObserver<Post>>();
        private AbstratRepository<int, Post> _repo;

        public PostsService(AbstratRepository<int, Post> repo)
        {
            _repo = repo;
        }

        public void RegistrateObs(ICustomObserver<Post> ob)
        {
            AddObserver(ob);
        }

        public List<Post> GetAll()
        {
            return (List<Post>)_repo.GetAll();
        }

        public void Add(Post p)
        {
            _repo.Add(p);
            NotifyObservers();
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
            NotifyObservers();
        }


        public void Update(Post p)
        {
            _repo.Update(p);
            NotifyObservers();
        }

        public void AddObserver(ICustomObserver<Post> o)
        {
            _observers.Add(o);
        }

        public void DeleteObserver(ICustomObserver<Post> o)
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
