using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            if(!infoCheckBox.Checked)
            {
                MessageBox.Show("개인정보 처리방침에 동의해 주세요.");
                return;
            }

            Server server = Server.GetInstance();
            string nickname = nicknameTextBox.Text;

            Regex nicknameRegex = new Regex(@"^[!-~가-힣]{2,20}$");
            Match nicknameMatch = nicknameRegex.Match(nickname);

            if(nicknameMatch.Success)
            {
                /* 계정 생성 후 로그인 */
                server.Regist(id, password, nickname);
                string loginString = server.Login(id, password);
                server.AccountJSON(loginString);

                Close();
                Program.Form = Program.Forms.Main;
                Program.nickname = nickname;
            }
            else
            {
                MessageBox.Show("2~20자의 아스키 문자, 한글만 가능합니다.");
            }
        }

        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Form = Program.Forms.Exit;
        }

        private void WelcomeForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    registButton_Click(sender, e);
                    break;
            }
        }

        private void infoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://qcoder.site/policy/privacy");
        }
    }
}
