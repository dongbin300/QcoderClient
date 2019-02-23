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
using System.Net.NetworkInformation;

namespace Qcoder
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Server server = Server.GetInstance();
            string id = idTextBox.Text;
            string password = passwordTextBox.Text;

            Regex idRegex = new Regex(@"^[0-9A-Za-z`_-]{4,20}$");
            Match idMatch = idRegex.Match(id);
            Regex passwordRegex = new Regex(@"^(?=.*[0-9])(?=.*[A-Za-z])(?=.*[!-/:-@\\[-`\\{-~])[!-~]{8,20}$");
            Match passwordMatch = passwordRegex.Match(password);
            
            if(idMatch.Success && passwordMatch.Success)
            {
                /* 서버에 로그인 요청 */
                string loginString = server.Login(id, password);
                server.AccountJSON(loginString);

                /* 아이디가 존재하지 않은 경우 -> 생성 */
                if (server.errorCode == "103")
                {
                    Close();
                    Program.Form = Program.Forms.Welcome;
                    Program.id = id;
                    Program.password = password;
                }
                /* 아이디만 일치하는 경우 */
                else if (server.errorCode == "104")
                {
                    MessageBox.Show("비밀번호가 틀립니다.");
                }
                /* 아이디 혹은 패스워드를 입력하지 않았을 경우 */
                else if (server.errorCode == "101")
                {
                    MessageBox.Show("아이디와 비밀번호를 모두 입력해 주세요.");
                }
                /* 인자의 값이 양식에 맞지 않았을 경우 */
                else if (server.errorCode == "102")
                {
                    MessageBox.Show("잘못된 요청입니다.");
                }
                /* 로그인이 이미 되어 있는 경우 */
                else if (server.errorCode == "106")
                {
                    MessageBox.Show("중복된 로그인 요청입니다.");
                }
                /* 탈퇴된 아이디일 경우 */
                /*
                else if(server.state == "UNREGISTERED")
                {
                    MessageBox.Show("탈퇴된 아이디입니다.");
                }
                */
                /* 아이디와 비밀번호 모두 일치하는 경우 */
                else
                {
                    MessageBox.Show("확인되었습니다.");
                    Close();
                    Program.Form = Program.Forms.Main;
                    Program.nickname = server.userNick;
                    Program.jsonString = loginString;
                }
            }
            else if(idMatch.Success)
            {
                MessageBox.Show("비밀번호는 8~20자, 최소 알파벳 1, 숫자 1, 특수문자 1자를 포함해야 합니다.");
            }
            else if(passwordMatch.Success)
            {
                MessageBox.Show("아이디는 4~20자의 알파벳, 숫자, `, _, -만 허용합니다.");
            }
            else
            {
                MessageBox.Show("아이디는 4~20자의 알파벳, 숫자, `, _, -만 허용합니다.\n비밀번호는 8~20자, 최소 알파벳 1, 숫자 1, 특수문자 1자를 포함해야 합니다.");
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Form = Program.Forms.Exit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server server = Server.GetInstance();
            string id = "testman10";
            string password = "1q2w3e4r!";

            /* 서버에 로그인 요청 */
            string loginString = server.Login(id, password);
            server.AccountJSON(loginString);

            Close();
            Program.Form = Program.Forms.Main;
            Program.nickname = server.userNick;
            Program.jsonString = loginString;
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    loginButton_Click(sender, e);
                    break;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
