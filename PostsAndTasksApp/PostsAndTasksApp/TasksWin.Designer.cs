namespace PostsAndTasksApp
{
    partial class TasksWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClearTask = new System.Windows.Forms.Button();
            this.buttonUpdateTask = new System.Windows.Forms.Button();
            this.buttonDeleteTask = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.labelTasks = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxIDTask = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelIdTask = new System.Windows.Forms.Label();
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonClearTask
            // 
            this.buttonClearTask.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonClearTask.Location = new System.Drawing.Point(586, 194);
            this.buttonClearTask.Name = "buttonClearTask";
            this.buttonClearTask.Size = new System.Drawing.Size(75, 23);
            this.buttonClearTask.TabIndex = 35;
            this.buttonClearTask.Text = "Clear";
            this.buttonClearTask.UseVisualStyleBackColor = false;
            this.buttonClearTask.Click += new System.EventHandler(this.buttonClearTask_Click);
            // 
            // buttonUpdateTask
            // 
            this.buttonUpdateTask.BackColor = System.Drawing.Color.LightCoral;
            this.buttonUpdateTask.Location = new System.Drawing.Point(505, 194);
            this.buttonUpdateTask.Name = "buttonUpdateTask";
            this.buttonUpdateTask.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateTask.TabIndex = 34;
            this.buttonUpdateTask.Text = "Update";
            this.buttonUpdateTask.UseVisualStyleBackColor = false;
            this.buttonUpdateTask.Click += new System.EventHandler(this.buttonUpdateTask_Click);
            // 
            // buttonDeleteTask
            // 
            this.buttonDeleteTask.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDeleteTask.Location = new System.Drawing.Point(419, 194);
            this.buttonDeleteTask.Name = "buttonDeleteTask";
            this.buttonDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteTask.TabIndex = 33;
            this.buttonDeleteTask.Text = "Delete";
            this.buttonDeleteTask.UseVisualStyleBackColor = false;
            this.buttonDeleteTask.Click += new System.EventHandler(this.buttonDeleteTask_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.BackColor = System.Drawing.Color.LightCoral;
            this.buttonAddTask.Location = new System.Drawing.Point(336, 194);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(77, 23);
            this.buttonAddTask.TabIndex = 32;
            this.buttonAddTask.Text = "Add";
            this.buttonAddTask.UseVisualStyleBackColor = false;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // labelTasks
            // 
            this.labelTasks.AutoSize = true;
            this.labelTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTasks.Location = new System.Drawing.Point(28, 23);
            this.labelTasks.Name = "labelTasks";
            this.labelTasks.Size = new System.Drawing.Size(59, 20);
            this.labelTasks.TabIndex = 31;
            this.labelTasks.Text = "Tasks :";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(419, 149);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(223, 20);
            this.textBoxDuration.TabIndex = 30;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(419, 107);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(223, 20);
            this.textBoxDescription.TabIndex = 29;
            // 
            // textBoxIDTask
            // 
            this.textBoxIDTask.Location = new System.Drawing.Point(419, 65);
            this.textBoxIDTask.Name = "textBoxIDTask";
            this.textBoxIDTask.Size = new System.Drawing.Size(223, 20);
            this.textBoxIDTask.TabIndex = 28;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(342, 156);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(53, 13);
            this.labelDuration.TabIndex = 27;
            this.labelDuration.Text = "Duration :";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(339, 114);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(66, 13);
            this.labelDescription.TabIndex = 26;
            this.labelDescription.Text = "Description :";
            // 
            // labelIdTask
            // 
            this.labelIdTask.AutoSize = true;
            this.labelIdTask.Location = new System.Drawing.Point(342, 65);
            this.labelIdTask.Name = "labelIdTask";
            this.labelIdTask.Size = new System.Drawing.Size(24, 13);
            this.labelIdTask.TabIndex = 25;
            this.labelIdTask.Text = "ID :";
            // 
            // listViewTasks
            // 
            this.listViewTasks.Location = new System.Drawing.Point(29, 65);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(286, 250);
            this.listViewTasks.TabIndex = 24;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewTasks_MouseClickEvent);
            // 
            // TasksWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 380);
            this.Controls.Add(this.buttonClearTask);
            this.Controls.Add(this.buttonUpdateTask);
            this.Controls.Add(this.buttonDeleteTask);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.labelTasks);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxIDTask);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelIdTask);
            this.Controls.Add(this.listViewTasks);
            this.Name = "TasksWin";
            this.Text = "TasksWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClearTask;
        private System.Windows.Forms.Button buttonUpdateTask;
        private System.Windows.Forms.Button buttonDeleteTask;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Label labelTasks;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxIDTask;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelIdTask;
        private System.Windows.Forms.ListView listViewTasks;
    }
}