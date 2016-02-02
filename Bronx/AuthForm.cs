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
using System.Threading;

namespace Bronx
{
    public partial class AuthForm : Form
    {
        public MySqlConnection conn;

        public AuthForm()
        {
            InitializeComponent();
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Text = "Connecting to server";
                
                conn = new MySqlConnection(string.Format("server={0};port=3306;user={1};password={2};database=mysql", Host.Text, User.Text, Password.Text));
                conn.Open();
                MainForm mn = new MainForm(conn);
                mn.Show();
                Hide();
            }
            catch
            {
                conn.Close();
                toolStripStatusLabel1.Text = "Wrong data";
                Password.Text = "";
            }
        }

        private void AuthForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13)) // enter
                bConnect_Click(sender, e);
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }
    }
}

