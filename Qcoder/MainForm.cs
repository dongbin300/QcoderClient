using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qcoder
{
    public partial class MainForm : Form
    {
        public string nickname { get; set; }
        public string jsonString { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            nicknameLabel.Text = nickname;
            jsonLabel.Text = jsonString;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Server server = Server.GetInstance();
            server.Logout(server.accessToken);

            Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Server server = Server.GetInstance();
            server.Logout(server.accessToken);

            Visible = false;
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
