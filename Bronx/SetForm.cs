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
    public partial class SetForm : Form
    {
        MySqlConnection conn;
        MainForm parent;
        string what;

        public SetForm()
        {
            InitializeComponent();
        }

        public SetForm(MySqlConnection _conn, MainForm _parent, string _what)
        {
            InitializeComponent();
            conn = _conn;
            what = _what;
            parent = _parent;

            if (what == "grant")
                this.Text = "Grant";
            if (what == "revoke")
            {
                this.Text = "Revoke";
                Option.Visible = false;
            }

            Privilege.Items.Add("ALL PRIVILEGES");
            Privilege.Items.Add("FILE");
            Privilege.Items.Add("RELOAD");
            Privilege.Items.Add("ALTER");
            Privilege.Items.Add("INDEX");
            Privilege.Items.Add("SELECT");
            Privilege.Items.Add("CREATE");
            Privilege.Items.Add("INSERT");
            Privilege.Items.Add("SHUTDOWN");
            Privilege.Items.Add("DELETE");
            Privilege.Items.Add("PROCESS");
            Privilege.Items.Add("UPDATE");
            Privilege.Items.Add("DROP");
            Privilege.Items.Add("REFERENCES");
            Privilege.Items.Add("USAGE");

            MySqlCommand command = new MySqlCommand("SHOW DATABASES", conn);
            MySqlDataReader what_we_got = null;
            try
            {
                what_we_got = command.ExecuteReader();

                while (what_we_got.Read())
                {
                    DataBase.Items.Add(string.Format("{0}", what_we_got.GetString(0)));
                }
                DataBase.Items.Add("*");
            }
            finally
            {
                if (null != what_we_got)
                    what_we_got.Close();
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (what == "grant")
            {
                MySqlCommand command;
                if (Option.Checked)
                    command = new MySqlCommand(string.Format("GRANT {0} ON {1}.{2} TO {3} WITH GRANT OPTION", Privilege.Text, DataBase.Text, Table.Text, parent.UsersList.SelectedItem), conn);
                else
                    command = new MySqlCommand(string.Format("GRANT {0} ON {1}.{2} TO {3}", Privilege.Text, DataBase.Text, Table.Text, parent.UsersList.SelectedItem), conn);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    if (command != null)
                        command.Cancel();
                }
            }

            if (what == "revoke")
            {
                MySqlCommand command = new MySqlCommand(string.Format("REVOKE {0} ON {1}.{2} FROM {3}", Privilege.Text, DataBase.Text, Table.Text, parent.UsersList.SelectedItem), conn);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    if (command != null)
                        command.Cancel();
                }
            }

            Close();
        }

        private void AddNewForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13)) // enter
                OK_Click(sender, e);
        }

        private void DataBase_SelectedValueChanged(object sender, EventArgs e)
        {
            Table.Items.Clear();
            if (DataBase.SelectedItem.ToString() == "*")
                Table.Items.Add("*");
            else
            {
                MySqlCommand command = new MySqlCommand(string.Format("SHOW TABLES FROM {0}", DataBase.SelectedItem), conn);
                MySqlDataReader what_we_got = null;
                try
                {
                    what_we_got = command.ExecuteReader();

                    while (what_we_got.Read())
                    {
                        Table.Items.Add(string.Format("{0}", what_we_got.GetString(0)));
                    }
                    Table.Items.Add("*");
                }
                finally
                {
                    if (null != what_we_got)
                        what_we_got.Close();
                }
            }
        }
    }
}
