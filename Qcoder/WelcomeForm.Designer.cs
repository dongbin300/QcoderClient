namespace Qcoder
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
            this.nicknameTextBox.Size = new System.Drawing.Size(176, 21);
            this.nicknameTextBox.TabIndex = 1;
            // 
            // registButton
            // 
            this.registButton.Location = new System.Drawing.Point(196, 9);
            this.registButton.Name = "registButton";
            this.registButton.Size = new System.Drawing.Size(75, 49);
            this.registButton.TabIndex = 2;
            this.registButton.Text = "생성";
            this.registButton.UseVisualStyleBackColor = true;
            this.registButton.Click += new System.EventHandler(this.registButton_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 66);
            this.Controls.Add(this.registButton);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeForm";
            this.Text = "가입";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.Button registButton;
    }
}