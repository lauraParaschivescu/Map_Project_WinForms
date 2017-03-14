using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostsAndTasksConsoleApp.Domain;

namespace PostsAndTasksConsoleApp.Repository
{
    public class PostsRepository : AbstratRepository<int, Post>
    {
        public PostsRepository(IValidator<Post> val) : base(val) { }
    }
}
