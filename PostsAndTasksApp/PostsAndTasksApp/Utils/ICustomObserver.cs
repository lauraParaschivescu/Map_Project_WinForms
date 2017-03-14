using System.Collections.Generic;

namespace PostsAndTasksApp.Utils
{
    public interface ICustomObserver<E>
    {
        void Update(List<E> lst);
    }
}
