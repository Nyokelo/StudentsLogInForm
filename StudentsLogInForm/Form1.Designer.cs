namespace StudentsLogInForm
{
    partial class StudentLogIn
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(182, 87);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(56, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "user name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(270, 80);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(202, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // txtAdmin
            // 
            this.txtAdmin.Location = new System.Drawing.Point(270, 121);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(202, 20);
            this.txtAdmin.TabIndex = 3;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(182, 128);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(46, 13);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Text = "Adm no.";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(308, 247);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "log in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // StudentLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 359);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentLogIn";
            this.Text = "StudentLogInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnLogIn;
    }
}

