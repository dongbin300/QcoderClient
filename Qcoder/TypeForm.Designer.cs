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
            this.cancelButton = new System.Windows.Forms.Button();
            this.percentLabel = new System.Windows.Forms.Label();
            this.tpmLabel = new System.Windows.Forms.Label();
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
            this.answerTextBox.Location = new System.Drawing.Point(12, 38);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(150, 22);
            this.answerTextBox.TabIndex = 1;
            this.answerTextBox.TextChanged += new System.EventHandler(this.answerTextBox_TextChanged);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("굴림", 9.75F);
            this.scoreLabel.Location = new System.Drawing.Point(889, 50);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(42, 20);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "00000";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressCountLabel
            // 
            this.progressCountLabel.Font = new System.Drawing.Font("굴림", 9.75F);
            this.progressCountLabel.Location = new System.Drawing.Point(791, 20);
            this.progressCountLabel.Name = "progressCountLabel";
            this.progressCountLabel.Size = new System.Drawing.Size(80, 20);
            this.progressCountLabel.TabIndex = 3;
            this.progressCountLabel.Text = "000 / 000";
            this.progressCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.Font = new System.Drawing.Font("굴림", 9.75F);
            this.accuracyLabel.Location = new System.Drawing.Point(877, 20);
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(54, 20);
            this.accuracyLabel.TabIndex = 4;
            this.accuracyLabel.Text = "00.00";
            this.accuracyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // typeSpeedLabel
            // 
            this.typeSpeedLabel.Font = new System.Drawing.Font("굴림", 9.75F);
            this.typeSpeedLabel.Location = new System.Drawing.Point(889, 80);
            this.typeSpeedLabel.Name = "typeSpeedLabel";
            this.typeSpeedLabel.Size = new System.Drawing.Size(42, 20);
            this.typeSpeedLabel.TabIndex = 5;
            this.typeSpeedLabel.Text = "00000";
            this.typeSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.Font = new System.Drawing.Font("굴림", 9.75F);
            this.elapsedTimeLabel.Location = new System.Drawing.Point(889, 485);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(42, 20);
            this.elapsedTimeLabel.TabIndex = 6;
            this.elapsedTimeLabel.Text = "00:00";
            this.elapsedTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // languageTypeLabel
            // 
            this.languageTypeLabel.AutoSize = true;
            this.languageTypeLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.languageTypeLabel.Location = new System.Drawing.Point(12, 485);
            this.languageTypeLabel.Name = "languageTypeLabel";
            this.languageTypeLabel.Size = new System.Drawing.Size(113, 13);
            this.languageTypeLabel.TabIndex = 7;
            this.languageTypeLabel.Text = "_language_type_";
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(0, 517);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(960, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "그만하기";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // percentLabel
            // 
            this.percentLabel.Font = new System.Drawing.Font("굴림", 9.75F);
            this.percentLabel.Location = new System.Drawing.Point(928, 20);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(19, 20);
            this.percentLabel.TabIndex = 9;
            this.percentLabel.Text = "%";
            this.percentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpmLabel
            // 
            this.tpmLabel.Font = new System.Drawing.Font("굴림", 9.75F);
            this.tpmLabel.Location = new System.Drawing.Point(930, 80);
            this.tpmLabel.Name = "tpmLabel";
            this.tpmLabel.Size = new System.Drawing.Size(40, 20);
            this.tpmLabel.TabIndex = 10;
            this.tpmLabel.Text = "t/m";
            this.tpmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.tpmLabel);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.languageTypeLabel);
            this.Controls.Add(this.elapsedTimeLabel);
            this.Controls.Add(this.typeSpeedLabel);
            this.Controls.Add(this.accuracyLabel);
            this.Controls.Add(this.progressCountLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.exampleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "TypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "d";
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
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Label tpmLabel;
    }
}