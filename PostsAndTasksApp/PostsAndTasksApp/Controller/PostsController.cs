using System.Collections.Generic;
using PostsAndTasksApp.Service;
using PostsAndTasksApp.Utils;
using PostsAndTasksConsoleApp.Domain;

namespace PostsAndTasksConsoleApp.Controller
{
    public class PostsController
    {
        private IValidator<Post> _val;
        private PostsService _service;

        public PostsController(IValidator<Post> val, PostsService service)
        {
            _val = val;
            _service = service;
        }

        public void RegistrateObs(ICustomObserver<Post> ob)
        {
            _service.RegistrateObs(ob);
        }

        public void Add(int id, string name, string type)
        {
            Post post = new Post()
            {
                Id = id,
                Name = name,
                Type = type
            };
            _val.Validate(post);
            _service.Add(post);
        }

        public List<Post> GetAll()
        {
            return _service.GetAll();
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }

        public void Update(int id, string name, string type)
        {
            Post post = new Post()
            {
                Id = id,
                Name = name,
                Type = type
            };
            _val.Validate(post);
            _service.Update(post);
        }
    }
}
