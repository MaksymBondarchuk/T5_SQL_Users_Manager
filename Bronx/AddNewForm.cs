using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bronx
{
    public partial class AddNewForm : Form
    {
        bool clicked = false;
        string what;

        MySqlConnection conn;
        MainForm parent;

        public AddNewForm()
        {
            InitializeComponent();
        }

        public AddNewForm(MySqlConnection _conn, MainForm _parent, string _what)
        {
            InitializeComponent();
            conn = _conn;
            parent = _parent;
            what = _what;
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            if (what == "add")
            {
                if (Password.Text == CPassword.Text)
                {
                    MySqlCommand command = new MySqlCommand(string.Format("CREATE USER '{0}'@'{1}' IDENTIFIED BY '{2}'", User.Text, Host.Text, Password.Text), conn);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        if (command != null)
                            command.Cancel();
                    }

                    parent.UsersList.Items.Add(string.Format("'{0}'@'{1}'", User.Text, Host.Text));
                    Close();
                }
                else
                    MessageBox.Show("Passwords must mutch", "Wrong data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (what == "change")
            {
                if (Password.Text != "" && Password.Text == CPassword.Text)
                {
                    MySqlCommand command = new MySqlCommand(string.Format("SET PASSWORD FOR {0} = PASSWORD('{1}')", parent.UsersList.SelectedItem, Password.Text), conn);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        if (command != null)
                            command.Cancel();
                    }
                    Close();
                }
                else
                    if (Password.Text != "")
                        MessageBox.Show("Passwords must mutch", "Wrong data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (User.Text != "" && Host.Text != "")
                {
                    MySqlCommand command = new MySqlCommand(string.Format("RENAME USER {0} TO '{1}'@'{2}'", parent.UsersList.SelectedItem, User.Text, Host.Text), conn);
                    try
                    {
                        command.ExecuteNonQuery();
                        parent.UsersList.Items.Remove(parent.UsersList.SelectedItem);
                        parent.UsersList.Items.Add(string.Format("'{0}'@'{1}'", User.Text, Host.Text));
                    }
                    catch
                    {
                        if (command != null)
                            command.Cancel();
                    }
                    Close();
                }
            }
        }

        private void AddNewForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13)) // enter
                bConnect_Click(sender, e);
        }
    }
}
