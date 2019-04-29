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
        public static int fontSize;

        public MainForm(string nickname)
        {
            InitializeComponent();
            this.nickname = nickname;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                nicknameLabel.Text = nickname;
                fontSize = Properties.Settings.Default.fontSize;

                /* 데이터 목록에 있는 언어 콤보박스에 추가 */
                languageComboBox.Items.Add("(All)");

                languageComboBox.SelectedIndex = 0;

                /* 데이터 목록 불러오기 */
                Server server = Server.GetInstance();
                server.WordJSON(server.RequestDataList(server.accessToken, "word")); // nullable
                for (int i = 0; i < server.list.Count; i++)
                {
                    if (!languageComboBox.Items.Contains(server.language[i]))
                    {
                        languageComboBox.Items.Add(server.language[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Form = Program.Forms.Exit;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                /* 로그아웃 */
                Server server = Server.GetInstance();
                server.Logout(server.accessToken);

                Close();
                Program.Form = Program.Forms.Login;
            }
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    MessageBox.Show("단어: 한 단어를 연습합니다.\n" +
                                "짧은글: 짧은 글을 연습합니다.\n" +
                                "긴글: 긴 글을 연습합니다.\n" +
                                "게임: 게임을 플레이합니다.\n" +
                                "로그아웃: 로그아웃을 합니다.", "메뉴 도움말");
                    break;
            }
        }

        private void wordButton_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
                Program.language = languageComboBox.SelectedItem.ToString();
                Program.typeMode = TypeForm.TypeModes.Word;
                Program.Form = Program.Forms.Type;
            }
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
            }
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
                Program.language = languageComboBox.SelectedItem.ToString();
                Program.Form = Program.Forms.Game;
            }
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
            }
        }

        private void unregistButton_Click(object sender, EventArgs e)
        {
            Close();
            Program.Form = Program.Forms.Unregist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Program.Form = Program.Forms.Settings;
        }

        private void sentenceButton_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
                Program.language = languageComboBox.SelectedItem.ToString();
                Program.typeMode = TypeForm.TypeModes.Sentence;
                Program.Form = Program.Forms.Type;
            }
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
            }
        }

        private void articleButton_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
                Program.language = languageComboBox.SelectedItem.ToString();
                Program.typeMode = TypeForm.TypeModes.Article;
                Program.Form = Program.Forms.Type;
            }
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
            }
        }

        private void rankingButton_Click(object sender, EventArgs e)
        {
            Close();
            Program.Form = Program.Forms.Ranking;
        }
    }
}
