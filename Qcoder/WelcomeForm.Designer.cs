﻿namespace Qcoder
{
    partial class WelcomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.registButton = new System.Windows.Forms.Button();
            this.infoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.infoCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "계정을 새로 생성합니다.\r\n사용할 닉네임을 입력해 주세요.";
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(13, 37);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(201, 21);
            this.nicknameTextBox.TabIndex = 1;
            // 
            // registButton
            // 
            this.registButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registButton.Location = new System.Drawing.Point(228, 9);
            this.registButton.Name = "registButton";
            this.registButton.Size = new System.Drawing.Size(75, 49);
            this.registButton.TabIndex = 2;
            this.registButton.Text = "생성";
            this.registButton.UseVisualStyleBackColor = true;
            this.registButton.Click += new System.EventHandler(this.registButton_Click);
            // 
            // infoLinkLabel
            // 
            this.infoLinkLabel.AutoSize = true;
            this.infoLinkLabel.Location = new System.Drawing.Point(226, 63);
            this.infoLinkLabel.Name = "infoLinkLabel";
            this.infoLinkLabel.Size = new System.Drawing.Size(81, 12);
            this.infoLinkLabel.TabIndex = 4;
            this.infoLinkLabel.TabStop = true;
            this.infoLinkLabel.Text = "처리방침 확인";
            this.infoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.infoLinkLabel_LinkClicked);
            // 
            // infoCheckBox
            // 
            this.infoCheckBox.AutoSize = true;
            this.infoCheckBox.Location = new System.Drawing.Point(14, 62);
            this.infoCheckBox.Name = "infoCheckBox";
            this.infoCheckBox.Size = new System.Drawing.Size(200, 16);
            this.infoCheckBox.TabIndex = 5;
            this.infoCheckBox.Text = "개인정보 처리방침에 동의합니다";
            this.infoCheckBox.UseVisualStyleBackColor = true;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 84);
            this.Controls.Add(this.infoCheckBox);
            this.Controls.Add(this.infoLinkLabel);
            this.Controls.Add(this.registButton);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "가입";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WelcomeForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WelcomeForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.Button registButton;
        private System.Windows.Forms.LinkLabel infoLinkLabel;
        private System.Windows.Forms.CheckBox infoCheckBox;
    }
}