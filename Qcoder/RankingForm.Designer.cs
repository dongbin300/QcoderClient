namespace Qcoder
{
    partial class RankingForm
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
            this.typeModeButton = new System.Windows.Forms.Button();
            this.criteriaButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.rankingListView = new System.Windows.Forms.ListView();
            this.rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancelButton = new System.Windows.Forms.Button();
            this.tpm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accuracy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.completion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeLimit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.regDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // typeModeButton
            // 
            this.typeModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeModeButton.Location = new System.Drawing.Point(12, 12);
            this.typeModeButton.Name = "typeModeButton";
            this.typeModeButton.Size = new System.Drawing.Size(85, 23);
            this.typeModeButton.TabIndex = 0;
            this.typeModeButton.Text = "단어";
            this.typeModeButton.UseVisualStyleBackColor = true;
            this.typeModeButton.Click += new System.EventHandler(this.typeModeButton_Click);
            // 
            // criteriaButton
            // 
            this.criteriaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.criteriaButton.Location = new System.Drawing.Point(103, 12);
            this.criteriaButton.Name = "criteriaButton";
            this.criteriaButton.Size = new System.Drawing.Size(85, 23);
            this.criteriaButton.TabIndex = 1;
            this.criteriaButton.Text = "타자 속도";
            this.criteriaButton.UseVisualStyleBackColor = true;
            this.criteriaButton.Click += new System.EventHandler(this.criteriaButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Location = new System.Drawing.Point(194, 12);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(85, 23);
            this.orderButton.TabIndex = 2;
            this.orderButton.Text = "내림차순";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // rankingListView
            // 
            this.rankingListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rank,
            this.id,
            this.score,
            this.tpm,
            this.accuracy,
            this.completion,
            this.progress,
            this.timeLimit,
            this.regDate});
            this.rankingListView.Location = new System.Drawing.Point(13, 42);
            this.rankingListView.Name = "rankingListView";
            this.rankingListView.Size = new System.Drawing.Size(500, 229);
            this.rankingListView.TabIndex = 3;
            this.rankingListView.UseCompatibleStateImageBehavior = false;
            this.rankingListView.View = System.Windows.Forms.View.Details;
            // 
            // rank
            // 
            this.rank.Text = "순위";
            this.rank.Width = 36;
            // 
            // id
            // 
            this.id.Text = "아이디";
            // 
            // score
            // 
            this.score.Text = "점수";
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(440, 277);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(73, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "취소";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tpm
            // 
            this.tpm.Text = "TPM";
            this.tpm.Width = 40;
            // 
            // accuracy
            // 
            this.accuracy.Text = "정확도";
            // 
            // completion
            // 
            this.completion.Text = "완성";
            this.completion.Width = 40;
            // 
            // progress
            // 
            this.progress.Text = "진행";
            this.progress.Width = 40;
            // 
            // timeLimit
            // 
            this.timeLimit.Text = "시간";
            this.timeLimit.Width = 40;
            // 
            // regDate
            // 
            this.regDate.Text = "등록";
            this.regDate.Width = 120;
            // 
            // RankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 306);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.rankingListView);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.criteriaButton);
            this.Controls.Add(this.typeModeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RankingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RankingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RankingForm_FormClosing);
            this.Load += new System.EventHandler(this.RankingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button typeModeButton;
        private System.Windows.Forms.Button criteriaButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.ListView rankingListView;
        private System.Windows.Forms.ColumnHeader rank;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader score;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ColumnHeader tpm;
        private System.Windows.Forms.ColumnHeader accuracy;
        private System.Windows.Forms.ColumnHeader completion;
        private System.Windows.Forms.ColumnHeader progress;
        private System.Windows.Forms.ColumnHeader timeLimit;
        private System.Windows.Forms.ColumnHeader regDate;
    }
}