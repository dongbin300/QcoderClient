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
    public partial class TypeForm : Form
    {
        private string example;
        private string answer;
        private string[] words = { "printf", "scanf", "fprintf", "fscanf", "puts", "gets", "fputs", "fgets", "putchar", "getchar", "if", "else if", "else", "for", "while", "do while", "switch case", "break", "continue", "int", "float", "double", "long", "char", "strlen", "strcat", "strcpy", "strcmp", "strtok", "fopen", "fclose", "memset", "malloc", "FILE*", "char*", "bool", "void", "main" };
        private float elapsedTime;
        private int progressWord;
        private int completionWord;
        private int accuracy;
        private int typeSpeed;
        private int score;

        public TypeForm()
        {
            InitializeComponent();
        }

        private void NewExample()
        {
            Random random = new Random();

            example = words[random.Next(words.Length)];
            exampleLabel.Text = example;
        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {
            answer = answerTextBox.Text;

            if(answer.Length > 0 && answer.Length == example.Length)
            {
                if (example == answer)
                {
                    progressWord++;
                    completionWord++;
                    score += example.Length * 10;

                    NewExample();
                    
                    answerTextBox.Clear();
                }
                else
                {
                    progressWord++;

                    NewExample();
                    answerTextBox.Clear();
                }
                accuracy = (int)((float)completionWord / progressWord * 100.0f);
            }
        }

        private void TypeForm_Load(object sender, EventArgs e)
        {
            elapsedTime = 0;
            progressWord = 0;
            completionWord = 0;
            accuracy = 0;
            typeSpeed = 0;
            score = 0;

            /* 첫 단어 생성 */
            NewExample();

            /* 타이머 생성 */
            mainTimer.Start();
        }

        private void TypeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* 로그아웃 */
            Server server = Server.GetInstance();
            server.Logout(server.accessToken);

            Program.FormNumber = -1;
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime += 0.1f;
            typeSpeed = (int)(score / elapsedTime * 6);
            elapsedTimeLabel.Text = string.Format("0:{0:00}", (int)elapsedTime);
            progressCountLabel.Text = $"{completionWord} / {progressWord}";
            accuracyLabel.Text = $"{accuracy} %";
            typeSpeedLabel.Text = $"{typeSpeed} t/s";
            scoreLabel.Text = $"{score}";

            if(elapsedTime >= 60.0f)
            {
                mainTimer.Stop();
                Server server = Server.GetInstance();
                string resultMessage = $"{server.userNick} 님\n\n진행한 시간: {string.Format("{0}", (int)elapsedTime)}초\n진행한 단어: {progressWord}\n완성한 단어: {completionWord}\n정확도: {accuracy}%\n타자 속도: {typeSpeed}t/s\n점수: {score}";
                MessageBox.Show(resultMessage, "타자연습(단어)");
                Close();
                Program.FormNumber = 3;
            }
        }

        private void TypeForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    MessageBox.Show("위에 제시된 단어를 따라서 입력합니다.", "타자 도움말");
                    break;
            }
        }
    }
}
