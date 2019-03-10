using System;
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
    public partial class TypeForm : Form
    {
        public enum TypeModes { Word, Sentence, Article };
        private TypeModes typeMode;
        private string language;
        public static int[] timeLimit = { 60, 120, 180 };

        private string example;
        private string answer;
        private string[] languages;
        private string[] types;
        private string[] contents;
        private float elapsedTime;
        private int progressStage;
        private int completionStage;
        private int progressLetter;
        private int completionLetter;
        private float accuracy;
        private int TPM;
        private int score;
        private int rightLetterCount;

        SoundPlayer hitSound;
        SoundPlayer correctSound;
        SoundPlayer incorrectSound;

        public TypeForm(TypeModes typeMode, string language)
        {
            InitializeComponent();
            this.typeMode = typeMode;
            this.language = language;
        }

        private void NewWordExample()
        {
            Random random = new Random();
            int index = random.Next(contents.Length);
            example = contents[index];
            exampleLabel.Text = example;
            languageTypeLabel.Text = $"{languages[index]} {types[index]}";
        }

        private void NewSentenceExample()
        {
            Random random = new Random();
            int index1 = random.Next(contents.Length);
            int index2 = random.Next(contents.Length);
            int index3 = random.Next(contents.Length);
            example = contents[index1] + " " + contents[index2] + " " + contents[index3];
            exampleLabel.Text = example;
            languageTypeLabel.Text = $"{languages[index1]}";
        }

        private void NewArticleExample()
        {
            Random random = new Random();
            int index1 = random.Next(contents.Length);
            int index2 = random.Next(contents.Length);
            int index3 = random.Next(contents.Length);
            example = contents[index1] + " " + contents[index2] + " " + contents[index3];
            exampleLabel.Text = example;
            languageTypeLabel.Text = $"{languages[index1]}";
        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {
            //hitSound.Play();
            answer = answerTextBox.Text;

            /* 실시간 글자 체크 */
            rightLetterCount = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == example[i])
                {
                    rightLetterCount++;
                }
            }

            if (answer.Length > 0 && answer.Length == example.Length)
            {
                progressStage++;
                progressLetter += example.Length;
                completionLetter += rightLetterCount;

                /* 정답 */
                if (example == answer)
                {
                    //correctSound.Play();

                    completionStage++;
                    score += example.Length * 10;
                }
                /* 오답 */
                else
                {
                    //incorrectSound.Play();
                }

                /* 새로운 문제 */
                switch (typeMode)
                {
                    case TypeModes.Word:
                        NewWordExample();
                        break;
                    case TypeModes.Sentence:
                        NewSentenceExample();
                        break;
                    case TypeModes.Article:
                        NewArticleExample();
                        break;
                }
                answerTextBox.Clear();
            }
            /* 정확도 계산 */
            accuracy = (float)(completionLetter + rightLetterCount) / (progressLetter + answer.Length) * 100.0f;
        }

        private void TypeForm_Load(object sender, EventArgs e)
        {
            /* 폼 설정 */
            switch (typeMode)
            {
                case TypeModes.Word:
                    answerTextBox.Size = new Size(150, 22);
                    break;
                case TypeModes.Sentence:
                    answerTextBox.Size = new Size(450, 22);
                    break;
                case TypeModes.Article:
                    break;
            }

            /* 사운드 설정 */
            hitSound = new SoundPlayer(@"keyboard.wav");
            correctSound = new SoundPlayer(@"correct.wav");
            incorrectSound = new SoundPlayer(@"incorrect.wav");

            /* 폰트 설정 */
            exampleLabel.Font = new Font("굴림", MainForm.fontSize);
            languageTypeLabel.Font = new Font("굴림", MainForm.fontSize);
            elapsedTimeLabel.Font = new Font("굴림", MainForm.fontSize);
            scoreLabel.Font = new Font("굴림", MainForm.fontSize);
            progressCountLabel.Font = new Font("굴림", MainForm.fontSize);
            accuracyLabel.Font = new Font("굴림", MainForm.fontSize);
            typeSpeedLabel.Font = new Font("굴림", MainForm.fontSize);
            answerTextBox.Font = new Font("굴림", MainForm.fontSize);
            percentLabel.Font = new Font("굴림", MainForm.fontSize);
            tpmLabel.Font = new Font("굴림", MainForm.fontSize);

            /* 설정 초기화 */
            elapsedTime = 0;
            progressStage = 0;
            completionStage = 0;
            progressLetter = 0;
            completionLetter = 0;
            accuracy = 0;
            TPM = 0;
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

            /* 첫 문제 생성 */
            switch (typeMode)
            {
                case TypeModes.Word:
                    NewWordExample();
                    break;
                case TypeModes.Sentence:
                    NewSentenceExample();
                    break;
                case TypeModes.Article:
                    NewArticleExample();
                    break;
            }

            /* 타이머 생성 */
            mainTimer.Start();
        }

        private void TypeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainTimer.Stop();
            Program.Form = Program.Forms.Main;
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime += 0.1f;
            TPM = (int)((score + rightLetterCount * 10) / elapsedTime * 6);
            elapsedTimeLabel.Text = string.Format("{0:0}:{1:00}", (int)elapsedTime / 60, (int)elapsedTime % 60);
            progressCountLabel.Text = $"{completionStage} / {progressStage}";
            accuracyLabel.Text = string.Format("{0:0.00}", accuracy);
            typeSpeedLabel.Text = $"{TPM}";
            scoreLabel.Text = $"{score}";

            /* 제한 시간 끝 */
            if (elapsedTime >= timeLimit[(int)typeMode])
            {
                mainTimer.Stop();
                Server server = Server.GetInstance();

                /* 랭킹 등록 */
                server.SaveRecord(typeMode, server.accessToken, progressStage, completionStage, accuracy, TPM, score);

                /* 결과 창 */
                switch(typeMode)
                {
                    case TypeModes.Word:
                        MessageBox.Show($"{server.userNick} 님\n\n진행한 단어: {progressStage}\n완성한 단어: {completionStage}\n정확도: {accuracy}%\n타자 속도: {TPM}t/m\n점수: {score}", "타자연습(단어)");
                        break;
                    case TypeModes.Sentence:
                        MessageBox.Show($"{server.userNick} 님\n\n진행한 문장: {progressStage}\n완성한 문장: {completionStage}\n정확도: {accuracy}%\n타자 속도: {TPM}t/m\n점수: {score}", "타자연습(짧은 글)");
                        break;
                    case TypeModes.Article:
                        MessageBox.Show($"{server.userNick} 님\n\n정확도: {accuracy}%\n타자 속도: {TPM}t/m\n점수: {score}", "타자연습(긴 글)");
                        break;
                }
                Close();
                Program.Form = Program.Forms.Main;
            }
        }

        private void TypeForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    MessageBox.Show("위에 제시된 문제를 따라서 입력합니다.", "타자 도움말");
                    break;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
