using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostsAndTasksApp.Domain;
using PostsAndTasksConsoleApp.Domain;
using PostsAndTasksConsoleApp.Repository;

namespace PostsAndTasksApp.Repository
{
    public class JobDescriptionRepository
    {
        private List<JobDescription> _listOfJobDescriptions;

        public JobDescriptionRepository()
        {
            _listOfJobDescriptions = new List<JobDescription>();
        }

        public void Add(JobDescription jd)
        {
            if (_listOfJobDescriptions.FindIndex(x => x.PostVar.Id.Equals(jd.PostVar.Id)) == -1)
                _listOfJobDescriptions.Add(jd);
            else
                throw new ValidationException("nu putem adauga de mai multe ori aceiasi pozitie!");
        }

        public void Delete(string namePosition)
        {
            _listOfJobDescriptions.RemoveAt(_listOfJobDescriptions.FindIndex(x => x.PostVar.Name.Equals(namePosition)));
        }

        public IEnumerable<JobDescription> GetAll()
        {
            return _listOfJobDescriptions;
        }
    }
}
