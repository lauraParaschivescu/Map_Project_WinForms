using System;
using System.IO;
using PostsAndTasksConsoleApp;
using PostsAndTasksConsoleApp.Domain;
using PostsAndTasksConsoleApp.Repository;

namespace PostsAndTasksApp.Repository
{
    public class FileTasksRepository : AbstratRepository<int, Task>
    {
        private string _fileName;
        public FileTasksRepository(IValidator<Task> val, string fileName) : base(val)
        {
            _fileName = fileName;
            ReadFromFile();
        }

        public void ReadFromFile()
        {
            using (StreamReader sr = new StreamReader(_fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] filds = line.Split('|');
                    Task t = new Task()
                    {
                        Id = Int32.Parse(filds[0]),
                        Description = filds[1],
                        Duration = Int32.Parse(filds[2])
                    };

                    base.Add(t);
                }
                sr.Close();
            }
        }

        public void WriteToFile()
        {
            StreamWriter sw = new StreamWriter(_fileName);
            foreach (var task in GetAll())
            {
                string line = task.Id.ToString() + "|" + task.Description + "|" + task.Duration.ToString();
                sw.WriteLine(line);
            }
            sw.Close();
        }

        public override void Add(Task p)
        {
            base.Add(p);
            WriteToFile();
        }

        public override void Delete(int id)
        {
            base.Delete(id);
            WriteToFile();
        }

        public override void Update(Task p)
        {
            base.Update(p);
            WriteToFile();
        }
    }
}
