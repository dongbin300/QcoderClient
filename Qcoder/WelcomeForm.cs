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
    public partial class WelcomeForm : Form
    {
        public string id;
        public string password;

        public WelcomeForm(string id, string password)
        {
            InitializeComponent();
            this.id = id;
            this.password = password;
        }

        private void registButton_Click(object sender, EventArgs e)
        {
            Server server = Server.GetInstance();
            string nickname = nicknameTextBox.Text;

            /* 계정 생성 후 로그인 */
            server.Regist(id, password, nickname);
            string loginString = server.Login(id, password);
            server.ReadJSON(loginString);

            Close();
            Program.Form = Program.Forms.Main;
            Program.nickname = nickname;
        }

        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Form = Program.Forms.Exit;
        }
    }
}
