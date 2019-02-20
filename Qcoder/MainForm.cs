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

        public MainForm(string nickname, string jsonString)
        {
            InitializeComponent();
            this.nickname = nickname;
            this.jsonString = jsonString;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            nicknameLabel.Text = nickname;
            jsonLabel.Text = jsonString;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* 로그아웃 */
            Server server = Server.GetInstance();
            server.Logout(server.accessToken);

            Program.FormNumber = -1;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            /* 로그아웃 */
            Server server = Server.GetInstance();
            server.Logout(server.accessToken);

            Close();
            Program.FormNumber = 1;
        }
    }
}
