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
    public partial class MainForm : Form
    {
        MySqlConnection conn;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(MySqlConnection _conn)
        {
            InitializeComponent();
            conn = _conn;

            // Load users
            MySqlCommand command = new MySqlCommand("SELECT Host, User FROM mysql.user", conn);
            MySqlDataReader what_we_got = null;
            try
            {
                what_we_got = command.ExecuteReader();

                while (what_we_got.Read())
                {
                    UsersList.Items.Add(string.Format("'{0}'@'{1}'", what_we_got.GetString("User"), what_we_got.GetString("Host")));
                }
            }
            finally
            {
                if (null != what_we_got)
                    what_we_got.Close();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UsersList.SelectedItem != null)
            {
                Info.Clear();
                StringBuilder form_comm = new StringBuilder();
                form_comm.Append(string.Format("SHOW GRANTS FOR {0}", UsersList.SelectedItem));
                MySqlCommand command = new MySqlCommand(form_comm.ToString(), conn);
                MySqlDataReader what_we_got = null;

                try
                {
                    what_we_got = command.ExecuteReader();

                    what_we_got.Read();

                    Info.Text += what_we_got.GetString(0) + Environment.NewLine;
                }
                finally
                {
                    if (null != what_we_got)
                        what_we_got.Close();
                }
            }
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewForm an = new AddNewForm(conn, this, "add");
            an.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand(string.Format("DROP USER {0}", UsersList.SelectedItem), conn);
            try
            {
                command.ExecuteNonQuery();
                UsersList.Items.Remove(UsersList.SelectedItem);
            }
            catch
            {
                if (command != null)
                    command.Cancel();
            }
        }

        private void changeDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewForm an = new AddNewForm(conn, this, "change");
            an.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setPrivilegiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm sf = new SetForm(conn, this, "grant");
            sf.Show();
        }

        private void removePrivilegiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm sf = new SetForm(conn, this, "revoke");
            sf.Show();
        }
    }
}
