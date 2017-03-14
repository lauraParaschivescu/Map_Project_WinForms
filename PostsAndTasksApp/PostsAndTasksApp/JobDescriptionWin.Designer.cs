namespace PostsAndTasksApp
{
    partial class JobDescriptionWin
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
            this.listViewTasksJob = new System.Windows.Forms.ListView();
            this.listViewJobDescriptions = new System.Windows.Forms.ListView();
            this.lbPositions = new System.Windows.Forms.Label();
            this.lbTasks = new System.Windows.Forms.Label();
            this.lbJobDescriptions = new System.Windows.Forms.Label();
            this.btnAddJobDescription = new System.Windows.Forms.Button();
            this.btnDeleteJobDescription = new System.Windows.Forms.Button();
            this.listViewPositionsJob = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewTasksJob
            // 
            this.listViewTasksJob.Location = new System.Drawing.Point(308, 60);
            this.listViewTasksJob.Name = "listViewTasksJob";
            this.listViewTasksJob.Size = new System.Drawing.Size(289, 217);
            this.listViewTasksJob.TabIndex = 1;
            this.listViewTasksJob.UseCompatibleStateImageBehavior = false;
            // 
            // listViewJobDescriptions
            // 
            this.listViewJobDescriptions.Location = new System.Drawing.Point(34, 330);
            this.listViewJobDescriptions.Name = "listViewJobDescriptions";
            this.listViewJobDescriptions.Size = new System.Drawing.Size(567, 172);
            this.listViewJobDescriptions.TabIndex = 2;
            this.listViewJobDescriptions.UseCompatibleStateImageBehavior = false;
            // 
            // lbPositions
            // 
            this.lbPositions.AutoSize = true;
            this.lbPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPositions.Location = new System.Drawing.Point(30, 27);
            this.lbPositions.Name = "lbPositions";
            this.lbPositions.Size = new System.Drawing.Size(95, 24);
            this.lbPositions.TabIndex = 3;
            this.lbPositions.Text = "Positions :";
            // 
            // lbTasks
            // 
            this.lbTasks.AutoSize = true;
            this.lbTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTasks.Location = new System.Drawing.Point(318, 27);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(69, 24);
            this.lbTasks.TabIndex = 4;
            this.lbTasks.Text = "Tasks :";
            // 
            // lbJobDescriptions
            // 
            this.lbJobDescriptions.AutoSize = true;
            this.lbJobDescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJobDescriptions.Location = new System.Drawing.Point(30, 303);
            this.lbJobDescriptions.Name = "lbJobDescriptions";
            this.lbJobDescriptions.Size = new System.Drawing.Size(154, 24);
            this.lbJobDescriptions.TabIndex = 5;
            this.lbJobDescriptions.Text = "JobDescriptions :";
            // 
            // btnAddJobDescription
            // 
            this.btnAddJobDescription.Location = new System.Drawing.Point(620, 84);
            this.btnAddJobDescription.Name = "btnAddJobDescription";
            this.btnAddJobDescription.Size = new System.Drawing.Size(75, 23);
            this.btnAddJobDescription.TabIndex = 6;
            this.btnAddJobDescription.Text = "Add";
            this.btnAddJobDescription.UseVisualStyleBackColor = true;
            this.btnAddJobDescription.Click += new System.EventHandler(this.btnAddJobDescription_Click);
            // 
            // btnDeleteJobDescription
            // 
            this.btnDeleteJobDescription.Location = new System.Drawing.Point(620, 141);
            this.btnDeleteJobDescription.Name = "btnDeleteJobDescription";
            this.btnDeleteJobDescription.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteJobDescription.TabIndex = 7;
            this.btnDeleteJobDescription.Text = "Delete";
            this.btnDeleteJobDescription.UseVisualStyleBackColor = true;
            this.btnDeleteJobDescription.Click += new System.EventHandler(this.btnDeleteJobDescription_Click);
            // 
            // listViewPositionsJob
            // 
            this.listViewPositionsJob.HideSelection = false;
            this.listViewPositionsJob.Location = new System.Drawing.Point(34, 60);
            this.listViewPositionsJob.Name = "listViewPositionsJob";
            this.listViewPositionsJob.Size = new System.Drawing.Size(257, 217);
            this.listViewPositionsJob.TabIndex = 8;
            this.listViewPositionsJob.UseCompatibleStateImageBehavior = false;
            // 
            // JobDescriptionWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 527);
            this.Controls.Add(this.listViewPositionsJob);
            this.Controls.Add(this.btnDeleteJobDescription);
            this.Controls.Add(this.btnAddJobDescription);
            this.Controls.Add(this.lbJobDescriptions);
            this.Controls.Add(this.lbTasks);
            this.Controls.Add(this.lbPositions);
            this.Controls.Add(this.listViewJobDescriptions);
            this.Controls.Add(this.listViewTasksJob);
            this.Name = "JobDescriptionWin";
            this.Text = "JobDescriptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewTasksJob;
        private System.Windows.Forms.ListView listViewJobDescriptions;
        private System.Windows.Forms.Label lbPositions;
        private System.Windows.Forms.Label lbTasks;
        private System.Windows.Forms.Label lbJobDescriptions;
        private System.Windows.Forms.Button btnAddJobDescription;
        private System.Windows.Forms.Button btnDeleteJobDescription;
        private System.Windows.Forms.ListView listViewPositionsJob;
    }
}