using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PostsAndTasksApp.Controller;
using PostsAndTasksApp.Utils;
using PostsAndTasksConsoleApp;
using PostsAndTasksConsoleApp.Controller;

namespace PostsAndTasksApp
{
    public partial class TasksWin : Form, ICustomObserver<Task>
    {
        private TasksController _ctrlTasks;
        public TasksWin(TasksController ctrlTasks)
        {
            InitializeComponent();
            _ctrlTasks = ctrlTasks;

            BackColor = Color.LightBlue;
            listViewTasks.BackColor = Color.AliceBlue;

            listViewTasks.View = View.Details;
            listViewTasks.FullRowSelect = true;

            listViewTasks.Columns.Add("Id", 40);
            listViewTasks.Columns.Add("Nume Sarcina", 150);
            listViewTasks.Columns.Add("Durata Sarcina", 150);

            PopulateListView();
            RegistrateUI();
        }

        private void RegistrateUI()
        {
            _ctrlTasks.RegistrateObs(this);
        }

        private void PopulateListView()
        {
            List<Task> lst = _ctrlTasks.GetAll();
            foreach (var elem in lst)
            {
                if (elem != null)
                {
                    ListViewItem item = new ListViewItem(new[] { elem.Id.ToString(), elem.Description, elem.Duration.ToString() });
                    listViewTasks.Items.Add(item);
                }
            }
        }

        private void CleanTextBox()
        {
            textBoxIDTask.Text = "";
            textBoxDescription.Text = "";
            textBoxDuration.Text = "";
        }



        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            _ctrlTasks.Add(Int32.Parse(textBoxIDTask.Text), textBoxDescription.Text, Int32.Parse(textBoxDuration.Text));
            CleanTextBox();
        }

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            _ctrlTasks.Delete(Int32.Parse(textBoxIDTask.Text));
            CleanTextBox();
        }

        private void buttonUpdateTask_Click(object sender, EventArgs e)
        {
            _ctrlTasks.Update(Int32.Parse(textBoxIDTask.Text), textBoxDescription.Text, Int32.Parse(textBoxDuration.Text));
            CleanTextBox();
        }

        private void buttonClearTask_Click(object sender, EventArgs e)
        {
            CleanTextBox();
        }

        public void Update(List<Task> lst)
        {
            listViewTasks.Items.Clear();
            PopulateListView();
        }

        private void listViewTasks_MouseClickEvent(object sender, MouseEventArgs e)
        {
            textBoxIDTask.Text = listViewTasks.SelectedItems[0].SubItems[0].Text;
            textBoxDescription.Text = listViewTasks.SelectedItems[0].SubItems[1].Text;
            textBoxDuration.Text = listViewTasks.SelectedItems[0].SubItems[2].Text;
        }
    }
}
