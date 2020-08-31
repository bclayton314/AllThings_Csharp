namespace CsharpRESTClient
{
    partial class cmdGO
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
            this.txtRequestURI = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.cmdGO1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoBasicAuth = new System.Windows.Forms.RadioButton();
            this.rdoNTLMAuth = new System.Windows.Forms.RadioButton();
            this.rdoRollOwn = new System.Windows.Forms.RadioButton();
            this.rdoNetCred = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRequestURI
            // 
            this.txtRequestURI.Location = new System.Drawing.Point(96, 12);
            this.txtRequestURI.Name = "txtRequestURI";
            this.txtRequestURI.Size = new System.Drawing.Size(480, 20);
            this.txtRequestURI.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(96, 172);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(679, 262);
            this.txtResponse.TabIndex = 1;
            // 
            // cmdGO1
            // 
            this.cmdGO1.Location = new System.Drawing.Point(624, 5);
            this.cmdGO1.Name = "cmdGO1";
            this.cmdGO1.Size = new System.Drawing.Size(75, 23);
            this.cmdGO1.TabIndex = 2;
            this.cmdGO1.Text = "GO!";
            this.cmdGO1.UseVisualStyleBackColor = true;
            this.cmdGO1.Click += new System.EventHandler(this.cmdGO1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Request URI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Response:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(96, 38);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(134, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(415, 38);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(161, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNTLMAuth);
            this.groupBox1.Controls.Add(this.rdoBasicAuth);
            this.groupBox1.Location = new System.Drawing.Point(96, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 77);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auth Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoNetCred);
            this.groupBox2.Controls.Add(this.rdoRollOwn);
            this.groupBox2.Location = new System.Drawing.Point(415, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 76);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Technique";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "User Name:";
            // 
            // rdoBasicAuth
            // 
            this.rdoBasicAuth.AutoSize = true;
            this.rdoBasicAuth.Checked = true;
            this.rdoBasicAuth.Location = new System.Drawing.Point(7, 20);
            this.rdoBasicAuth.Name = "rdoBasicAuth";
            this.rdoBasicAuth.Size = new System.Drawing.Size(122, 17);
            this.rdoBasicAuth.TabIndex = 0;
            this.rdoBasicAuth.TabStop = true;
            this.rdoBasicAuth.Text = "Basic Authentication";
            this.rdoBasicAuth.UseVisualStyleBackColor = true;
            // 
            // rdoNTLMAuth
            // 
            this.rdoNTLMAuth.AutoSize = true;
            this.rdoNTLMAuth.Location = new System.Drawing.Point(7, 43);
            this.rdoNTLMAuth.Name = "rdoNTLMAuth";
            this.rdoNTLMAuth.Size = new System.Drawing.Size(108, 17);
            this.rdoNTLMAuth.TabIndex = 0;
            this.rdoNTLMAuth.TabStop = true;
            this.rdoNTLMAuth.Text = "NTLM (Windows)";
            this.rdoNTLMAuth.UseVisualStyleBackColor = true;
            // 
            // rdoRollOwn
            // 
            this.rdoRollOwn.AutoSize = true;
            this.rdoRollOwn.Checked = true;
            this.rdoRollOwn.Location = new System.Drawing.Point(7, 18);
            this.rdoRollOwn.Name = "rdoRollOwn";
            this.rdoRollOwn.Size = new System.Drawing.Size(93, 17);
            this.rdoRollOwn.TabIndex = 0;
            this.rdoRollOwn.TabStop = true;
            this.rdoRollOwn.Text = "Roll Your Own";
            this.rdoRollOwn.UseVisualStyleBackColor = true;
            // 
            // rdoNetCred
            // 
            this.rdoNetCred.AutoSize = true;
            this.rdoNetCred.Location = new System.Drawing.Point(7, 41);
            this.rdoNetCred.Name = "rdoNetCred";
            this.rdoNetCred.Size = new System.Drawing.Size(140, 17);
            this.rdoNetCred.TabIndex = 1;
            this.rdoNetCred.TabStop = true;
            this.rdoNetCred.Text = "NetworkCredential Class";
            this.rdoNetCred.UseVisualStyleBackColor = true;
            // 
            // cmdGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 548);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdGO1);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtRequestURI);
            this.Name = "cmdGO";
            this.Text = "C# REST Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRequestURI;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button cmdGO1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoNTLMAuth;
        private System.Windows.Forms.RadioButton rdoBasicAuth;
        private System.Windows.Forms.RadioButton rdoNetCred;
        private System.Windows.Forms.RadioButton rdoRollOwn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

