namespace Bronx
{
    partial class AddNewForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.TextBox();
            this.itstime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.Window;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.Location = new System.Drawing.Point(36, 118);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(182, 24);
            this.Password.TabIndex = 12;
            this.Password.UseSystemPasswordChar = true;
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.SystemColors.Window;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User.ForeColor = System.Drawing.Color.Black;
            this.User.Location = new System.Drawing.Point(36, 58);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(182, 24);
            this.User.TabIndex = 11;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(70, 284);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(96, 28);
            this.OK.TabIndex = 18;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Host";
            // 
            // Host
            // 
            this.Host.BackColor = System.Drawing.SystemColors.Window;
            this.Host.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Host.ForeColor = System.Drawing.Color.Black;
            this.Host.Location = new System.Drawing.Point(36, 245);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(182, 24);
            this.Host.TabIndex = 17;
            this.Host.Text = "localhost";
            // 
            // itstime
            // 
            this.itstime.AutoSize = true;
            this.itstime.Location = new System.Drawing.Point(185, 11);
            this.itstime.Name = "itstime";
            this.itstime.Size = new System.Drawing.Size(0, 13);
            this.itstime.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Confirm password";
            // 
            // CPassword
            // 
            this.CPassword.BackColor = System.Drawing.SystemColors.Window;
            this.CPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPassword.ForeColor = System.Drawing.Color.Black;
            this.CPassword.Location = new System.Drawing.Point(36, 179);
            this.CPassword.Name = "CPassword";
            this.CPassword.Size = new System.Drawing.Size(182, 24);
            this.CPassword.TabIndex = 13;
            this.CPassword.UseSystemPasswordChar = true;
            // 
            // AddNewForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 332);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CPassword);
            this.Controls.Add(this.itstime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User);
            this.MaximizeBox = false;
            this.Name = "AddNewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or change";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddNewForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Password;
        public System.Windows.Forms.TextBox User;
        public System.Windows.Forms.Button OK;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Host;
        public System.Windows.Forms.Label itstime;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox CPassword;
    }
}