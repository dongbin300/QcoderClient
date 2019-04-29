﻿namespace Qcoder
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.wordButton = new System.Windows.Forms.Button();
            this.sentenceButton = new System.Windows.Forms.Button();
            this.articleButton = new System.Windows.Forms.Button();
            this.gameButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.unregistButton = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rankingButton = new System.Windows.Forms.Button();
            this.ㅊ = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nicknameLabel.ForeColor = System.Drawing.Color.White;
            this.nicknameLabel.Location = new System.Drawing.Point(43, 9);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(62, 13);
            this.nicknameLabel.TabIndex = 0;
            this.nicknameLabel.Text = "userNick";
            // 
            // wordButton
            // 
            this.wordButton.FlatAppearance.BorderSize = 2;
            this.wordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wordButton.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.wordButton.ForeColor = System.Drawing.Color.White;
            this.wordButton.Location = new System.Drawing.Point(11, 44);
            this.wordButton.Name = "wordButton";
            this.wordButton.Size = new System.Drawing.Size(200, 80);
            this.wordButton.TabIndex = 1;
            this.wordButton.Text = "단어";
            this.wordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.wordButton.UseVisualStyleBackColor = true;
            this.wordButton.Click += new System.EventHandler(this.wordButton_Click);
            // 
            // sentenceButton
            // 
            this.sentenceButton.FlatAppearance.BorderSize = 2;
            this.sentenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sentenceButton.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sentenceButton.ForeColor = System.Drawing.Color.White;
            this.sentenceButton.Location = new System.Drawing.Point(232, 44);
            this.sentenceButton.Name = "sentenceButton";
            this.sentenceButton.Size = new System.Drawing.Size(200, 80);
            this.sentenceButton.TabIndex = 2;
            this.sentenceButton.Text = "짧은 글";
            this.sentenceButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sentenceButton.UseVisualStyleBackColor = true;
            this.sentenceButton.Click += new System.EventHandler(this.sentenceButton_Click);
            // 
            // articleButton
            // 
            this.articleButton.FlatAppearance.BorderSize = 2;
            this.articleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.articleButton.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.articleButton.ForeColor = System.Drawing.Color.White;
            this.articleButton.Location = new System.Drawing.Point(11, 144);
            this.articleButton.Name = "articleButton";
            this.articleButton.Size = new System.Drawing.Size(200, 80);
            this.articleButton.TabIndex = 3;
            this.articleButton.Text = "긴 글";
            this.articleButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.articleButton.UseVisualStyleBackColor = true;
            this.articleButton.Click += new System.EventHandler(this.articleButton_Click);
            // 
            // gameButton
            // 
            this.gameButton.FlatAppearance.BorderSize = 2;
            this.gameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameButton.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gameButton.ForeColor = System.Drawing.Color.White;
            this.gameButton.Location = new System.Drawing.Point(232, 144);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(200, 80);
            this.gameButton.TabIndex = 4;
            this.gameButton.Text = "게임";
            this.gameButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gameButton.UseVisualStyleBackColor = true;
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(110, 34);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(70, 22);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "로그아웃";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // unregistButton
            // 
            this.unregistButton.FlatAppearance.BorderSize = 0;
            this.unregistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unregistButton.ForeColor = System.Drawing.Color.DeepPink;
            this.unregistButton.Location = new System.Drawing.Point(186, 34);
            this.unregistButton.Name = "unregistButton";
            this.unregistButton.Size = new System.Drawing.Size(39, 22);
            this.unregistButton.TabIndex = 7;
            this.unregistButton.Text = "탈퇴";
            this.unregistButton.UseVisualStyleBackColor = true;
            this.unregistButton.Click += new System.EventHandler(this.unregistButton_Click);
            // 
            // languageComboBox
            // 
            this.languageComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.languageComboBox.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(11, 11);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(92, 21);
            this.languageComboBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.wordButton);
            this.panel1.Controls.Add(this.languageComboBox);
            this.panel1.Controls.Add(this.sentenceButton);
            this.panel1.Controls.Add(this.articleButton);
            this.panel1.Controls.Add(this.gameButton);
            this.panel1.Location = new System.Drawing.Point(1, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 237);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(17, 50);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 70);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(238, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(17, 150);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(238, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.rankingButton);
            this.panel2.Controls.Add(this.ㅊ);
            this.panel2.Controls.Add(this.logoutButton);
            this.panel2.Controls.Add(this.unregistButton);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.nicknameLabel);
            this.panel2.Location = new System.Drawing.Point(218, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 60);
            this.panel2.TabIndex = 10;
            // 
            // rankingButton
            // 
            this.rankingButton.FlatAppearance.BorderSize = 0;
            this.rankingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rankingButton.ForeColor = System.Drawing.Color.White;
            this.rankingButton.Location = new System.Drawing.Point(59, 34);
            this.rankingButton.Name = "rankingButton";
            this.rankingButton.Size = new System.Drawing.Size(53, 22);
            this.rankingButton.TabIndex = 9;
            this.rankingButton.Text = "랭킹";
            this.rankingButton.UseVisualStyleBackColor = true;
            this.rankingButton.Click += new System.EventHandler(this.rankingButton_Click);
            // 
            // ㅊ
            // 
            this.ㅊ.FlatAppearance.BorderSize = 0;
            this.ㅊ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ㅊ.ForeColor = System.Drawing.Color.White;
            this.ㅊ.Location = new System.Drawing.Point(12, 34);
            this.ㅊ.Name = "ㅊ";
            this.ㅊ.Size = new System.Drawing.Size(53, 22);
            this.ㅊ.TabIndex = 8;
            this.ㅊ.Text = "설정";
            this.ㅊ.UseVisualStyleBackColor = true;
            this.ㅊ.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(1, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(211, 57);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(445, 295);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qcoder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Button wordButton;
        private System.Windows.Forms.Button sentenceButton;
        private System.Windows.Forms.Button articleButton;
        private System.Windows.Forms.Button gameButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button unregistButton;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button ㅊ;
        private System.Windows.Forms.Button rankingButton;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}