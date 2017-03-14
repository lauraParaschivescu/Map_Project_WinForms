using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostsAndTasksConsoleApp.Domain;

namespace PostsAndTasksConsoleApp.Domain
{
    public class TaskValidator : IValidator<Task>
    {
        public void Validate(Task t)
        {
            StringBuilder err = new StringBuilder();
            if (t.Id < 0)
                err.Append("Id nu poate fi negativ!\n");
            if (t.Description == "")
                err.Append("Descrierea nu poate fi vid!\n");
            if (t.Duration < 0)
                err.Append("Durata nu poate fi negativa!\n");

            if (err.Length != 0)
                throw new ValidationException(err.ToString());
        }
    }
}
