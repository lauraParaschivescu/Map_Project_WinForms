using System;
using System.Windows.Forms;
using PostsAndTasksApp.Controller;
using PostsAndTasksApp.Repository;
using PostsAndTasksApp.Service;
using PostsAndTasksConsoleApp;
using PostsAndTasksConsoleApp.Controller;
using PostsAndTasksConsoleApp.Domain;
using PostsAndTasksConsoleApp.Repository;

namespace PostsAndTasksApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IValidator<Post> valPost = new PostValidator();
            IValidator<Task> valTask = new TaskValidator();
            //PostsRepository repoPosts = new PostsRepository(valPost);
            FilePostsRepository repoPosts = new FilePostsRepository(valPost, "D:/faculta/semIII/2_map/c#/PostsAndTasksApp/PostsAndTasksApp/Files/posts.txt");
            FileTasksRepository repoTasks = new FileTasksRepository(valTask, "D:/faculta/semIII/2_map/c#/PostsAndTasksApp/PostsAndTasksApp/Files/tasks.txt");
            JobDescriptionRepository repoJobDescription = new JobDescriptionRepository();

            PostsService servicePosts = new PostsService(repoPosts);
            TasksService serviceTasks = new TasksService(repoTasks);
            JobDescriptionService serviceJobDescription = new JobDescriptionService(servicePosts, serviceTasks, repoJobDescription);

            PostsController ctrlPosts = new PostsController(valPost, servicePosts);
            TasksController ctrlTasks = new TasksController(valTask, serviceTasks);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PositionsWin view = new PositionsWin(ctrlPosts, ctrlTasks, serviceJobDescription);
            
            Application.Run(view);
        }
    }
}
