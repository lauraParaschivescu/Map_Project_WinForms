using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsAndTasksConsoleApp.Repository
{
    public interface ICRUDRepository<ID, E>
    {
        void Add(E enity);
        void Delete(ID id);
        void Update(E enity);
        IEnumerable<E> GetAll();
    }
}
