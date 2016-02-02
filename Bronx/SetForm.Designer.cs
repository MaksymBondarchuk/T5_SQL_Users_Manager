namespace Bronx
{
    partial class SetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetForm));
            this.OK = new System.Windows.Forms.Button();
            this.Privilege = new System.Windows.Forms.ComboBox();
            this.DataBase = new System.Windows.Forms.ComboBox();
            this.Table = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Option = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(243, 157);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(96, 28);
            this.OK.TabIndex = 19;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Privilege
            // 
            this.Privilege.FormattingEnabled = true;
            this.Privilege.Location = new System.Drawing.Point(150, 50);
            this.Privilege.Name = "Privilege";
            this.Privilege.Size = new System.Drawing.Size(289, 21);
            this.Privilege.TabIndex = 20;
            // 
            // DataBase
            // 
            this.DataBase.FormattingEnabled = true;
            this.DataBase.Location = new System.Drawing.Point(150, 77);
            this.DataBase.Name = "DataBase";
            this.DataBase.Size = new System.Drawing.Size(289, 21);
            this.DataBase.TabIndex = 21;
            this.DataBase.SelectedValueChanged += new System.EventHandler(this.DataBase_SelectedValueChanged);
            // 
            // Table
            // 
            this.Table.FormattingEnabled = true;
            this.Table.Location = new System.Drawing.Point(150, 104);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(289, 21);
            this.Table.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(83, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Privilege";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(75, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "DataBase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(100, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Table";
            // 
            // Option
            // 
            this.Option.AutoSize = true;
            this.Option.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Option.Location = new System.Drawing.Point(243, 131);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(99, 20);
            this.Option.TabIndex = 26;
            this.Option.Text = "Grant option";
            this.Option.UseVisualStyleBackColor = true;
            // 
            // SetForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(554, 210);
            this.Controls.Add(this.Option);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.DataBase);
            this.Controls.Add(this.Privilege);
            this.Controls.Add(this.OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Give them rights... or not";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button OK;
        private System.Windows.Forms.ComboBox Privilege;
        private System.Windows.Forms.ComboBox DataBase;
        private System.Windows.Forms.ComboBox Table;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Option;
    }
}