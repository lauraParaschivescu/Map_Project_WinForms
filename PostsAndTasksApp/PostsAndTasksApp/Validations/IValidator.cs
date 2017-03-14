using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsAndTasksConsoleApp.Domain
{
    public interface IValidator<E>
    {
        void Validate(E enity);
    }
}
