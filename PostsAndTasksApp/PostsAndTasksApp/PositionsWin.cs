using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PostsAndTasksApp.Controller;
using PostsAndTasksApp.Service;
using PostsAndTasksApp.Utils;
using PostsAndTasksConsoleApp;
using PostsAndTasksConsoleApp.Controller;
using PostsAndTasksConsoleApp.Domain;

namespace PostsAndTasksApp
{
    public partial class PositionsWin : Form, ICustomObserver<Post>
    {
        private PostsController _ctrlPosts;
        private TasksController _ctrlTasks;
        private JobDescriptionService _serviceJobDescription;

        public PositionsWin(PostsController ctrlPosts, TasksController ctrlTasks, JobDescriptionService serviceJobDescription)
        {
            _ctrlPosts = ctrlPosts;
            _ctrlTasks = ctrlTasks;
            _serviceJobDescription = serviceJobDescription;

            InitializeComponent();

            BackColor = Color.LightBlue;
            listViewPosts.BackColor = Color.AliceBlue;

            listViewPosts.View = View.Details;
            listViewPosts.FullRowSelect = true;

            listViewPosts.Columns.Add("Id", 40);
            listViewPosts.Columns.Add("Nume Post", 150);
            listViewPosts.Columns.Add("Tip Post", 150);

            PopulateListView();
            RegistrateUI();
        }

        private void RegistrateUI()
        {
            _ctrlPosts.RegistrateObs(this);
        }

        private void PopulateListView()
        {
            List<Post> lst = _ctrlPosts.GetAll();
            foreach (var elem in lst)
            {
                if (elem != null)
                {
                    ListViewItem item = new ListViewItem(new[] {elem.Id.ToString(), elem.Name, elem.Type});
                    listViewPosts.Items.Add(item);
                }
            }
        }

        private void CleanTextBox()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtType.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(Regex.IsMatch(txtId.Text, @"^\d+$"))
                    _ctrlPosts.Add(Int32.Parse(txtId.Text), txtName.Text, txtType.Text);
                else if(txtName.Text != "" && txtType.Text != "" && !Regex.IsMatch(txtId.Text, @"^\d+$"))
                    MessageBox.Show("ID nu este numar\n", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    throw new ValidationException("Campurile nu pot fi nule!");
                }
            }
            catch (ValidationException msg)
            {
                if (Regex.IsMatch(txtId.Text, @"^\d+$"))
                    MessageBox.Show(msg.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("ID nu este numar\n" + msg.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            CleanTextBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           _ctrlPosts.Delete(Int32.Parse(txtId.Text));
            CleanTextBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtId.Text, @"^\d+$"))
                    _ctrlPosts.Update(Int32.Parse(txtId.Text), txtName.Text, txtType.Text);
                else if (txtName.Text != "" && txtType.Text != "" && !Regex.IsMatch(txtId.Text, @"^\d+$"))
                    MessageBox.Show("ID nu este numar\n", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    throw new ValidationException("Campurile nu pot fi nule!");
                }
            }
            catch (ValidationException msg)
            {
                if (Regex.IsMatch(txtId.Text, @"^\d+$"))
                    MessageBox.Show(msg.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("ID nu este numar\n" + msg.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            CleanTextBox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CleanTextBox();
        }

        private void listView_MouseClickEvent(object sender, MouseEventArgs e)
        {
            txtId.Text = listViewPosts.SelectedItems[0].SubItems[0].Text;
            txtName.Text = listViewPosts.SelectedItems[0].SubItems[1].Text;
            txtType.Text = listViewPosts.SelectedItems[0].SubItems[2].Text;
        }

        public void Update(List<Post> lst)
        {
            listViewPosts.Items.Clear();
            PopulateListView();
        }

        private void btnOpenTasks_Click(object sender, EventArgs e)
        {
            TasksWin viewTask = new TasksWin(_ctrlTasks);
            viewTask.ShowDialog(this);
        }

        private void btnJobDecription_Click(object sender, EventArgs e)
        {
            JobDescriptionWin viewJobDescriptionWin = new JobDescriptionWin(_serviceJobDescription);
            viewJobDescriptionWin.ShowDialog(this);
        }
    }
}
