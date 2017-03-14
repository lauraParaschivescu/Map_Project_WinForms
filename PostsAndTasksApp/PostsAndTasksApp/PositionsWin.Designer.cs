namespace PostsAndTasksApp
{
    partial class PositionsWin
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
            this.components = new System.ComponentModel.Container();
            this.listViewPosts = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.labelPosts = new System.Windows.Forms.Label();
            this.btnOpenTasks = new System.Windows.Forms.Button();
            this.testVmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnJobDecription = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.testVmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewPosts
            // 
            this.listViewPosts.Location = new System.Drawing.Point(51, 51);
            this.listViewPosts.Name = "listViewPosts";
            this.listViewPosts.Size = new System.Drawing.Size(298, 250);
            this.listViewPosts.TabIndex = 0;
            this.listViewPosts.UseCompatibleStateImageBehavior = false;
            this.listViewPosts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClickEvent);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightCoral;
            this.btnAdd.Location = new System.Drawing.Point(373, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(379, 51);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(24, 13);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "ID :";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(379, 93);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(41, 13);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name :";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(379, 136);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(37, 13);
            this.lbType.TabIndex = 4;
            this.lbType.Text = "Type :";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Info;
            this.txtId.Location = new System.Drawing.Point(457, 48);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(237, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Info;
            this.txtName.Location = new System.Drawing.Point(457, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.SystemColors.Info;
            this.txtType.Location = new System.Drawing.Point(457, 136);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(237, 20);
            this.txtType.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(456, 180);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightCoral;
            this.btnUpdate.Location = new System.Drawing.Point(542, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.Location = new System.Drawing.Point(623, 180);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosts.Location = new System.Drawing.Point(47, 9);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(77, 20);
            this.labelPosts.TabIndex = 11;
            this.labelPosts.Text = "Positions:";
            // 
            // btnOpenTasks
            // 
            this.btnOpenTasks.Location = new System.Drawing.Point(457, 241);
            this.btnOpenTasks.Name = "btnOpenTasks";
            this.btnOpenTasks.Size = new System.Drawing.Size(179, 41);
            this.btnOpenTasks.TabIndex = 12;
            this.btnOpenTasks.Text = "Open Tasks";
            this.btnOpenTasks.UseVisualStyleBackColor = true;
            this.btnOpenTasks.Click += new System.EventHandler(this.btnOpenTasks_Click);
            // 
            // testVmBindingSource
            // 
            this.testVmBindingSource.DataSource = typeof(PostsAndTasksApp.TestVm);
            // 
            // btnJobDecription
            // 
            this.btnJobDecription.Location = new System.Drawing.Point(457, 303);
            this.btnJobDecription.Name = "btnJobDecription";
            this.btnJobDecription.Size = new System.Drawing.Size(179, 41);
            this.btnJobDecription.TabIndex = 13;
            this.btnJobDecription.Text = "Job Description";
            this.btnJobDecription.UseVisualStyleBackColor = true;
            this.btnJobDecription.Click += new System.EventHandler(this.btnJobDecription_Click);
            // 
            // PositionsWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 392);
            this.Controls.Add(this.btnJobDecription);
            this.Controls.Add(this.btnOpenTasks);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listViewPosts);
            this.Name = "PositionsWin";
            this.Text = "PositionsWin";
            ((System.ComponentModel.ISupportInitialize)(this.testVmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listViewPosts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.BindingSource testVmBindingSource;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Button btnOpenTasks;
        private System.Windows.Forms.Button btnJobDecription;
    }
}

