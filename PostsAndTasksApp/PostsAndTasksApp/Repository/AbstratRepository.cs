using System.Collections.Generic;
using System.Linq;
using PostsAndTasksConsoleApp.Domain;

namespace PostsAndTasksConsoleApp.Repository
{
    public abstract class AbstratRepository<ID, E> : ICRUDRepository<ID, E> where E : HasId<ID>
    {
        private IValidator<E> _val;
        private List<E> _elements;

        public AbstratRepository(IValidator<E> val)
        {
            this._val = val;
            _elements = new List<E>();
        }

        public virtual void Add(E enity)
        {
            _val.Validate(enity);
            if (!_elements.Exists(x => x.Id.Equals(enity.Id)))
            {
                _elements.Add(enity);
            }
            else
            {
                throw new ValidationException("Mai exista o entitate cu id celei pe care tocmai ati dat-o!\n");
            }

        }

        public virtual void Delete(ID id)
        {
            if(!_elements.Remove(_elements.Single(x => x.Id.Equals(id))))
                throw new ValidationException("Elementul cu id dat nu exista momentan in baza noastra de date!\n");
        }

        public virtual void Update(E enity)
        {
            _val.Validate(enity);

            int index = _elements.FindIndex(x => x.Id.Equals(enity.Id));
            if(index == -1)
                throw new ValidationException("Nu ati lasat acelasi id");
            _elements[index] = enity;
        }

        public virtual IEnumerable<E> GetAll()
        {
            return _elements;
        }
    }
}
