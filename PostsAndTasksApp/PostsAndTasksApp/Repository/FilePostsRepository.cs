using System;
using System.IO;
using PostsAndTasksConsoleApp;
using PostsAndTasksConsoleApp.Domain;
using PostsAndTasksConsoleApp.Repository;

namespace PostsAndTasksApp.Repository
{
    public class FilePostsRepository : AbstratRepository<int, Post>
    {
        private string _fileName;
        public FilePostsRepository(IValidator<Post> val, string fileName) : base(val)
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
                    Post p = new Post()
                    {
                        Id = Int32.Parse(filds[0]),
                        Name = filds[1],
                        Type = filds[2]
                    };

                    base.Add(p);
                }
                sr.Close();
            }
        }

        public void WriteToFile()
        {
            StreamWriter sw = new StreamWriter(_fileName);
            foreach (var post in base.GetAll())
            {
                string line = post.Id.ToString() + "|" + post.Name + "|" + post.Type;
                sw.WriteLine(line);
            }
            sw.Close();
        }


        public override void Add(Post p)
        {
            base.Add(p);
            WriteToFile();
        }

        public override void Delete(int id)
        {
            base.Delete(id);
            WriteToFile();
        }

        public override void Update(Post p)
        {
            base.Update(p);
            WriteToFile();
        }
    }
}
