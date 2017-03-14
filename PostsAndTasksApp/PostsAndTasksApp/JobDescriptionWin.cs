using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostsAndTasksApp.Domain;
using PostsAndTasksApp.Service;
using PostsAndTasksApp.Utils;
using PostsAndTasksConsoleApp;
using PostsAndTasksConsoleApp.Domain;


namespace PostsAndTasksApp
{
    public partial class JobDescriptionWin : Form, ICustomObserver<JobDescription>
    {
        private JobDescriptionService _serviceJobDescription;

        public JobDescriptionWin(JobDescriptionService serviceJobDescription)
        {
            _serviceJobDescription = serviceJobDescription;

            InitializeComponent();
            BackColor = Color.LightBlue;
            listViewPositionsJob.BackColor = Color.AliceBlue;
            listViewTasksJob.BackColor = Color.AliceBlue;
            listViewJobDescriptions.BackColor = Color.AliceBlue;

            listViewPositionsJob.View = View.Details;
            listViewPositionsJob.FullRowSelect = true;

            listViewPositionsJob.Columns.Add("Id", 40);
            listViewPositionsJob.Columns.Add("Nume Post", 150);
            listViewPositionsJob.Columns.Add("Tip Post", 150);
            listViewPositionsJob.MultiSelect = false;

            listViewTasksJob.View = View.Details;
            listViewTasksJob.FullRowSelect = true;

            listViewTasksJob.Columns.Add("Id", 40);
            listViewTasksJob.Columns.Add("Nume Sarcina", 150);
            listViewTasksJob.Columns.Add("Durata Sarcina", 150);

            listViewJobDescriptions.View = View.Details;
            listViewJobDescriptions.FullRowSelect = true;

            listViewJobDescriptions.Columns.Add("Nume Post", 150);
            listViewJobDescriptions.Columns.Add("Lista Sarcini", 450);

            PopulatePositionsListView();
            PopulateTasksListView();
            PopulateJobDescriptionListView();

            RegistrateUI();
        }

        private void RegistrateUI()
        {
            _serviceJobDescription.RegistrateObs(this);
        }

        private void PopulatePositionsListView()
        {
            List<Post> lst = _serviceJobDescription.GetAllPosts();
            foreach (var elem in lst)
            {
                if (elem != null)
                {
                    ListViewItem item = new ListViewItem(new[] {elem.Id.ToString(), elem.Name, elem.Type});
                    listViewPositionsJob.Items.Add(item);
                }
            }
        }

        private void PopulateTasksListView()
        {
            List<PostsAndTasksConsoleApp.Task> lst = _serviceJobDescription.GetAllTasks();
            foreach (var elem in lst)
            {
                if (elem != null)
                {
                    ListViewItem item =
                        new ListViewItem(new[] {elem.Id.ToString(), elem.Description, elem.Duration.ToString()});
                    listViewTasksJob.Items.Add(item);
                }
            }
        }

        private void PopulateJobDescriptionListView()
        {
            List<JobDescription> lst = _serviceJobDescription.GetAll();
            foreach (var elem in lst)
            {
                if (elem != null)
                {
                    string listOfTasks = "";
                    foreach (var elemListOfTask in elem.ListOfTasks)
                    {
                        listOfTasks += elemListOfTask.Description + ", ";
                    }

                    ListViewItem item = new ListViewItem(new[] {elem.PostVar.Name, listOfTasks});
                    listViewJobDescriptions.Items.Add(item);
                }
            }
        }

        private void btnAddJobDescription_Click(object sender, EventArgs e)
        {
            Post p = new Post()
            {
                Id = Int32.Parse(listViewPositionsJob.SelectedItems[0].SubItems[0].Text),
                Name = listViewPositionsJob.SelectedItems[0].SubItems[1].Text,
                Type = listViewPositionsJob.SelectedItems[0].SubItems[2].Text
            };

            List<PostsAndTasksConsoleApp.Task> listOfTasks = new List<PostsAndTasksConsoleApp.Task>();
            int i = 0;
            foreach (var selectedItem in listViewTasksJob.SelectedItems)
            {
                listOfTasks.Add(new PostsAndTasksConsoleApp.Task()
                {
                    Id = Int32.Parse(listViewTasksJob.SelectedItems[i].SubItems[0].Text),
                    Description = listViewTasksJob.SelectedItems[i].SubItems[1].Text,
                    Duration = Int32.Parse(listViewTasksJob.SelectedItems[i].SubItems[2].Text)
                });
                i++;
            }

            JobDescription jd = new JobDescription(p, listOfTasks);
            try
            {
                _serviceJobDescription.Add(jd);

            }
            catch (ValidationException msg)
            {

                MessageBox.Show(msg.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteJobDescription_Click(object sender, EventArgs e)
        {
             _serviceJobDescription.Delete(listViewJobDescriptions.SelectedItems[0].SubItems[0].Text);
        }

        public void Update(List<JobDescription> lst)
        {
            listViewJobDescriptions.Items.Clear();
            PopulateJobDescriptionListView();
        }
    }
}
