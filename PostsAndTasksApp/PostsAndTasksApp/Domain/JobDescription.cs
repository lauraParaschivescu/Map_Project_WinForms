using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostsAndTasksConsoleApp;
using Task = PostsAndTasksConsoleApp.Task;

namespace PostsAndTasksApp.Domain
{
    public class JobDescription
    {
        private Post _post;
        private List<Task> _listOfTasks;
        public JobDescription(Post post, List<Task> listOfTasks)
        {
            _post = post;
            _listOfTasks = listOfTasks;
        }

        public Post PostVar { get { return _post; } }
        public List<Task> ListOfTasks { get { return _listOfTasks; } }
    }
}
