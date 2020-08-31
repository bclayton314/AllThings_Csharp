namespace TaskMasterTutorial
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCancelTask = new System.Windows.Forms.Button();
            this.cmdDeleteTask = new System.Windows.Forms.Button();
            this.cmdUpdateTask = new System.Windows.Forms.Button();
            this.cmdCreateTask = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTask = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 214);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.Size = new System.Drawing.Size(776, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdCancelTask);
            this.groupBox1.Controls.Add(this.cmdDeleteTask);
            this.groupBox1.Controls.Add(this.cmdUpdateTask);
            this.groupBox1.Controls.Add(this.cmdCreateTask);
            this.groupBox1.Controls.Add(this.cboStatus);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtTask);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Due Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Task:";
            // 
            // cmdCancelTask
            // 
            this.cmdCancelTask.Location = new System.Drawing.Point(306, 75);
            this.cmdCancelTask.Name = "cmdCancelTask";
            this.cmdCancelTask.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelTask.TabIndex = 6;
            this.cmdCancelTask.Text = "Cancel";
            this.cmdCancelTask.UseVisualStyleBackColor = true;
            this.cmdCancelTask.Click += new System.EventHandler(this.cmdCancelTask_Click);
            // 
            // cmdDeleteTask
            // 
            this.cmdDeleteTask.Location = new System.Drawing.Point(387, 46);
            this.cmdDeleteTask.Name = "cmdDeleteTask";
            this.cmdDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.cmdDeleteTask.TabIndex = 5;
            this.cmdDeleteTask.Text = "Delete";
            this.cmdDeleteTask.UseVisualStyleBackColor = true;
            this.cmdDeleteTask.Click += new System.EventHandler(this.cmdDeleteTask_Click);
            // 
            // cmdUpdateTask
            // 
            this.cmdUpdateTask.Location = new System.Drawing.Point(306, 46);
            this.cmdUpdateTask.Name = "cmdUpdateTask";
            this.cmdUpdateTask.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdateTask.TabIndex = 4;
            this.cmdUpdateTask.Text = "Update";
            this.cmdUpdateTask.UseVisualStyleBackColor = true;
            this.cmdUpdateTask.Click += new System.EventHandler(this.cmdUpdateTask_Click);
            // 
            // cmdCreateTask
            // 
            this.cmdCreateTask.Location = new System.Drawing.Point(225, 46);
            this.cmdCreateTask.Name = "cmdCreateTask";
            this.cmdCreateTask.Size = new System.Drawing.Size(75, 23);
            this.cmdCreateTask.TabIndex = 3;
            this.cmdCreateTask.Text = "Create";
            this.cmdCreateTask.UseVisualStyleBackColor = true;
            this.cmdCreateTask.Click += new System.EventHandler(this.cmdCreateTask_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(99, 46);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(120, 21);
            this.cboStatus.TabIndex = 2;
            this.cboStatus.Text = "Please Select...";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(570, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(99, 19);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(201, 20);
            this.txtTask.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(818, 494);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Master";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCancelTask;
        private System.Windows.Forms.Button cmdDeleteTask;
        private System.Windows.Forms.Button cmdUpdateTask;
        private System.Windows.Forms.Button cmdCreateTask;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTask;
    }
}

