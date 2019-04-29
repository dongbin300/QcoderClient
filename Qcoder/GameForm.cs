﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

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

        SoundPlayer hitSound;
        SoundPlayer correctSound;
        SoundPlayer incorrectSound;

        public GameForm(string language)
        {
            InitializeComponent();
            this.language = language;
        }

        private void NewExample()
        {
            try
            {
                Random random = new Random();
                int index = random.Next(contents.Length);
                example = contents[index];
                exampleLabel.Text = example;
                languageTypeLabel.Text = $"{languages[index]} {types[index]}";
                exampleLabel.Location = new Point(10 + random.Next(380), 10 + random.Next(380));
            }
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            try
            {
                /* 사운드 설정 */
                hitSound = new SoundPlayer(@"keyboard.wav");
                correctSound = new SoundPlayer(@"correct.wav");
                incorrectSound = new SoundPlayer(@"incorrect.wav");

                /* 폰트 설정 */
                exampleLabel.Font = new Font("굴림", MainForm.fontSize);
                languageTypeLabel.Font = new Font("굴림", MainForm.fontSize);
                elapsedTimeLabel.Font = new Font("굴림", MainForm.fontSize);
                scoreLabel.Font = new Font("굴림", MainForm.fontSize);
                typeSpeedLabel.Font = new Font("굴림", MainForm.fontSize);
                answerTextBox.Font = new Font("굴림", MainForm.fontSize);

                /* 설정 초기화 */
                elapsedTime = 0;
                typeSpeed = 0;
                score = 0;

                /* 선택한 언어만 리스트에 저장 */
                Server server = Server.GetInstance();

                languages = new string[server.list.Count];
                types = new string[server.list.Count];
                contents = new string[server.list.Count];
                if (language == "(All)")
                {
                    for (int i = 0, p = 0; i < server.list.Count; i++)
                    {
                        languages[p] = server.language[i];
                        types[p] = server.type[i];
                        contents[p++] = server.content[i];
                    }
                }
                else
                {
                    for (int i = 0, p = 0; i < server.list.Count; i++)
                    {
                        if (language == server.language[i])
                        {
                            languages[p] = server.language[i];
                            types[p] = server.type[i];
                            contents[p++] = server.content[i];
                        }
                    }
                }

                /* 첫 단어 생성 */
                NewExample();

                /* 타이머 생성 */
                mainTimer.Start();
            }
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                mainTimer.Stop();
                Program.Form = Program.Forms.Main;
            }
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
            }
        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //hitSound.Play();

                answer = answerTextBox.Text;

                if (answer.Length > 0 && answer.Length == example.Length)
                {
                    if (example == answer)
                    {
                        //correctSound.Play();

                        score += example.Length * 10;

                        NewExample();
                        answerTextBox.Clear();
                    }
                    else
                    {
                        //incorrectSound.Play();

                        NewExample();
                        answerTextBox.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
            }
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
