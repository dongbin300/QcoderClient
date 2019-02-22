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
    public partial class GameForm : Form
    {
        private string example;
        private string answer;
        private string[] languages;
        private string[] types;
        private string[] contents;
        private float elapsedTime;
        private int typeSpeed;
        private int score;
        private string language;

        public GameForm(string language)
        {
            InitializeComponent();
            this.language = language;
        }

        private void NewExample()
        {
            Random random = new Random();
            int index = random.Next(contents.Length);
            example = contents[index];
            exampleLabel.Text = example;
            languageTypeLabel.Text = $"{languages[index]} {types[index]}";
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            /* 설정 초기화 */
            elapsedTime = 0;
            typeSpeed = 0;
            score = 0;

            /* 선택한 언어만 리스트에 저장 */
            Server server = Server.GetInstance();

            languages = new string[server.list.Count];
            types = new string[server.list.Count];
            contents = new string[server.list.Count];
            for (int i = 0, p = 0; i < server.list.Count; i++)
            {
                if (language == server.language[i])
                {
                    languages[p] = server.language[i];
                    types[p] = server.type[i];
                    contents[p++] = server.content[i];
                }
            }

            /* 첫 단어 생성 */
            NewExample();

            /* 타이머 생성 */
            mainTimer.Start();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Form = Program.Forms.Exit;
        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {
            answer = answerTextBox.Text;

            if (answer.Length > 0 && answer.Length == example.Length)
            {
                if (example == answer)
                {
                    score += example.Length * 10;

                    NewExample();
                    answerTextBox.Clear();
                }
                else
                {
                    NewExample();
                    answerTextBox.Clear();
                }
            }
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime += 0.1f;
            typeSpeed = (int)(score / elapsedTime * 6);
            elapsedTimeLabel.Text = string.Format("0:{0:00}", (int)elapsedTime);
            typeSpeedLabel.Text = $"{typeSpeed} t/s";
            scoreLabel.Text = $"{score}";

            if (elapsedTime >= 60.0f)
            {
                mainTimer.Stop();
                Server server = Server.GetInstance();
                string resultMessage = $"{server.userNick} 님\n\n진행한 시간: {string.Format("{0}", (int)elapsedTime)}초\n타자 속도: {typeSpeed}t/s\n점수: {score}";
                MessageBox.Show(resultMessage, "타자연습(게임)");
                Close();
                Program.Form = Program.Forms.Main;
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    MessageBox.Show("1분동안 랜덤으로 생성되는 단어를 따라서 입력합니다.", "게임 도움말");
                    break;
            }
        }
    }
}
