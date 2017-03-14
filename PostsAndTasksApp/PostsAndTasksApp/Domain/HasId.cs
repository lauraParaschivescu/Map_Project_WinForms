using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsAndTasksConsoleApp
{
    public interface HasId<ID>
    {
        ID Id { get; set; }
    }
}
