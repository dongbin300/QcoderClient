namespace Qcoder
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
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.wordButton = new System.Windows.Forms.Button();
            this.sentenceButton = new System.Windows.Forms.Button();
            this.articleButton = new System.Windows.Forms.Button();
            this.gameButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(22, 17);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(35, 12);
            this.nicknameLabel.TabIndex = 0;
            this.nicknameLabel.Text = "_____";
            // 
            // wordButton
            // 
            this.wordButton.Location = new System.Drawing.Point(13, 51);
            this.wordButton.Name = "wordButton";
            this.wordButton.Size = new System.Drawing.Size(64, 64);
            this.wordButton.TabIndex = 1;
            this.wordButton.Text = "단어";
            this.wordButton.UseVisualStyleBackColor = true;
            // 
            // sentenceButton
            // 
            this.sentenceButton.Location = new System.Drawing.Point(83, 51);
            this.sentenceButton.Name = "sentenceButton";
            this.sentenceButton.Size = new System.Drawing.Size(64, 64);
            this.sentenceButton.TabIndex = 1;
            this.sentenceButton.Text = "짧은글";
            this.sentenceButton.UseVisualStyleBackColor = true;
            // 
            // articleButton
            // 
            this.articleButton.Location = new System.Drawing.Point(153, 51);
            this.articleButton.Name = "articleButton";
            this.articleButton.Size = new System.Drawing.Size(64, 64);
            this.articleButton.TabIndex = 1;
            this.articleButton.Text = "긴글";
            this.articleButton.UseVisualStyleBackColor = true;
            // 
            // gameButton
            // 
            this.gameButton.Location = new System.Drawing.Point(223, 51);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(64, 64);
            this.gameButton.TabIndex = 1;
            this.gameButton.Text = "게임";
            this.gameButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(223, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(64, 22);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "로그아웃";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 126);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.gameButton);
            this.Controls.Add(this.articleButton);
            this.Controls.Add(this.sentenceButton);
            this.Controls.Add(this.wordButton);
            this.Controls.Add(this.nicknameLabel);
            this.Name = "MainForm";
            this.Text = "메인";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Button wordButton;
        private System.Windows.Forms.Button sentenceButton;
        private System.Windows.Forms.Button articleButton;
        private System.Windows.Forms.Button gameButton;
        private System.Windows.Forms.Button logoutButton;
    }
}