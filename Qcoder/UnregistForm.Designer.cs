namespace Qcoder
{
    partial class UnregistForm
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
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.unregistButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "탈퇴 이유를 간략하게 100자 이내로 적어주세요.";
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.Location = new System.Drawing.Point(14, 24);
            this.reasonTextBox.Multiline = true;
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(344, 66);
            this.reasonTextBox.TabIndex = 1;
            // 
            // unregistButton
            // 
            this.unregistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unregistButton.ForeColor = System.Drawing.Color.Red;
            this.unregistButton.Location = new System.Drawing.Point(200, 96);
            this.unregistButton.Name = "unregistButton";
            this.unregistButton.Size = new System.Drawing.Size(75, 29);
            this.unregistButton.TabIndex = 2;
            this.unregistButton.Text = "탈퇴";
            this.unregistButton.UseVisualStyleBackColor = true;
            this.unregistButton.Click += new System.EventHandler(this.unregistButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(283, 96);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 29);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "취소";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // UnregistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 137);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.unregistButton);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnregistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "탈퇴";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnregistForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reasonTextBox;
        private System.Windows.Forms.Button unregistButton;
        private System.Windows.Forms.Button cancelButton;
    }
}