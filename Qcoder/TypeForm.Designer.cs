namespace Qcoder
{
    partial class TypeForm
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
            this.exampleLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.progressCountLabel = new System.Windows.Forms.Label();
            this.accuracyLabel = new System.Windows.Forms.Label();
            this.typeSpeedLabel = new System.Windows.Forms.Label();
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.languageTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exampleLabel
            // 
            this.exampleLabel.AutoSize = true;
            this.exampleLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exampleLabel.Location = new System.Drawing.Point(13, 13);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(28, 13);
            this.exampleLabel.TabIndex = 0;
            this.exampleLabel.Text = "text";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.answerTextBox.Location = new System.Drawing.Point(15, 29);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(100, 22);
            this.answerTextBox.TabIndex = 1;
            this.answerTextBox.TextChanged += new System.EventHandler(this.answerTextBox_TextChanged);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(284, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(35, 12);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "00000";
            // 
            // progressCountLabel
            // 
            this.progressCountLabel.AutoSize = true;
            this.progressCountLabel.Location = new System.Drawing.Point(223, 21);
            this.progressCountLabel.Name = "progressCountLabel";
            this.progressCountLabel.Size = new System.Drawing.Size(55, 12);
            this.progressCountLabel.TabIndex = 3;
            this.progressCountLabel.Text = "000 / 000";
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.AutoSize = true;
            this.accuracyLabel.Location = new System.Drawing.Point(282, 21);
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(37, 12);
            this.accuracyLabel.TabIndex = 4;
            this.accuracyLabel.Text = "100 %";
            // 
            // typeSpeedLabel
            // 
            this.typeSpeedLabel.AutoSize = true;
            this.typeSpeedLabel.Location = new System.Drawing.Point(270, 33);
            this.typeSpeedLabel.Name = "typeSpeedLabel";
            this.typeSpeedLabel.Size = new System.Drawing.Size(49, 12);
            this.typeSpeedLabel.TabIndex = 5;
            this.typeSpeedLabel.Text = "0000 t/s";
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.AutoSize = true;
            this.elapsedTimeLabel.Location = new System.Drawing.Point(288, 81);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(27, 12);
            this.elapsedTimeLabel.TabIndex = 6;
            this.elapsedTimeLabel.Text = "0:00";
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // languageTypeLabel
            // 
            this.languageTypeLabel.AutoSize = true;
            this.languageTypeLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.languageTypeLabel.Location = new System.Drawing.Point(14, 81);
            this.languageTypeLabel.Name = "languageTypeLabel";
            this.languageTypeLabel.Size = new System.Drawing.Size(113, 13);
            this.languageTypeLabel.TabIndex = 7;
            this.languageTypeLabel.Text = "_language_type_";
            // 
            // TypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 102);
            this.Controls.Add(this.languageTypeLabel);
            this.Controls.Add(this.elapsedTimeLabel);
            this.Controls.Add(this.typeSpeedLabel);
            this.Controls.Add(this.accuracyLabel);
            this.Controls.Add(this.progressCountLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.exampleLabel);
            this.KeyPreview = true;
            this.Name = "TypeForm";
            this.Text = "타자연습";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TypeForm_FormClosing);
            this.Load += new System.EventHandler(this.TypeForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TypeForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exampleLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label progressCountLabel;
        private System.Windows.Forms.Label accuracyLabel;
        private System.Windows.Forms.Label typeSpeedLabel;
        private System.Windows.Forms.Label elapsedTimeLabel;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label languageTypeLabel;
    }
}