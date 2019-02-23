namespace Qcoder
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
            this.typeSpeedLabel = new System.Windows.Forms.Label();
            this.languageTypeLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.answerTextBox.Location = new System.Drawing.Point(190, 472);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(135, 22);
            this.answerTextBox.TabIndex = 0;
            this.answerTextBox.TextChanged += new System.EventHandler(this.answerTextBox_TextChanged);
            // 
            // exampleLabel
            // 
            this.exampleLabel.AutoSize = true;
            this.exampleLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exampleLabel.Location = new System.Drawing.Point(13, 13);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(28, 13);
            this.exampleLabel.TabIndex = 1;
            this.exampleLabel.Text = "text";
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("굴림", 9.75F);
            this.scoreLabel.Location = new System.Drawing.Point(124, 476);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(60, 20);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "00000";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.elapsedTimeLabel.Location = new System.Drawing.Point(434, 476);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(50, 20);
            this.elapsedTimeLabel.TabIndex = 7;
            this.elapsedTimeLabel.Text = "0:00";
            this.elapsedTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // typeSpeedLabel
            // 
            this.typeSpeedLabel.Font = new System.Drawing.Font("굴림", 9.75F);
            this.typeSpeedLabel.Location = new System.Drawing.Point(331, 476);
            this.typeSpeedLabel.Name = "typeSpeedLabel";
            this.typeSpeedLabel.Size = new System.Drawing.Size(70, 20);
            this.typeSpeedLabel.TabIndex = 8;
            this.typeSpeedLabel.Text = "0000 t/s";
            // 
            // languageTypeLabel
            // 
            this.languageTypeLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.languageTypeLabel.Location = new System.Drawing.Point(0, 476);
            this.languageTypeLabel.Name = "languageTypeLabel";
            this.languageTypeLabel.Size = new System.Drawing.Size(145, 20);
            this.languageTypeLabel.TabIndex = 9;
            this.languageTypeLabel.Text = "_language_type_";
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(0, 507);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(484, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "그만하기";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 530);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.languageTypeLabel);
            this.Controls.Add(this.typeSpeedLabel);
            this.Controls.Add(this.elapsedTimeLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.exampleLabel);
            this.Controls.Add(this.answerTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "타자게임";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label exampleLabel;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label elapsedTimeLabel;
        private System.Windows.Forms.Label typeSpeedLabel;
        private System.Windows.Forms.Label languageTypeLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}