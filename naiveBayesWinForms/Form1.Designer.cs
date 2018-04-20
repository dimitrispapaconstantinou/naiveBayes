namespace naiveBayesWinForms
{
    partial class Form1
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
            this.gvSpam = new System.Windows.Forms.DataGridView();
            this.tokenSPAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propabilitySPAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvLegit = new System.Windows.Forms.DataGridView();
            this.tokenLEGIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propabilityLegit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gvScore = new System.Windows.Forms.DataGridView();
            this.ClassificationText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spamScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legitScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startBtn = new System.Windows.Forms.Button();
            this.step2Btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectFolderBtn = new System.Windows.Forms.Button();
            this.selectFolderTxt = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.step10Btn = new System.Windows.Forms.Button();
            this.step9Btn = new System.Windows.Forms.Button();
            this.step8Btn = new System.Windows.Forms.Button();
            this.step7Btn = new System.Windows.Forms.Button();
            this.step6Btn = new System.Windows.Forms.Button();
            this.step5Btn = new System.Windows.Forms.Button();
            this.step4Btn = new System.Windows.Forms.Button();
            this.step3Btn = new System.Windows.Forms.Button();
            this.gvAverage = new System.Windows.Forms.DataGridView();
            this.spamAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legitAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spamRecallLabel = new System.Windows.Forms.Label();
            this.spaPrecisionLabel5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tspLBL = new System.Windows.Forms.Label();
            this.msgIdAsSpam = new System.Windows.Forms.Label();
            this.msgCorrectlyIdAsSpam = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvSpam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLegit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvScore)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAverage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvSpam
            // 
            this.gvSpam.AllowUserToAddRows = false;
            this.gvSpam.AllowUserToDeleteRows = false;
            this.gvSpam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSpam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tokenSPAM,
            this.propabilitySPAM});
            this.gvSpam.Location = new System.Drawing.Point(12, 267);
            this.gvSpam.Name = "gvSpam";
            this.gvSpam.ReadOnly = true;
            this.gvSpam.Size = new System.Drawing.Size(251, 214);
            this.gvSpam.TabIndex = 0;
            // 
            // tokenSPAM
            // 
            this.tokenSPAM.HeaderText = "Token";
            this.tokenSPAM.Name = "tokenSPAM";
            this.tokenSPAM.ReadOnly = true;
            // 
            // propabilitySPAM
            // 
            this.propabilitySPAM.HeaderText = "Propability";
            this.propabilitySPAM.Name = "propabilitySPAM";
            this.propabilitySPAM.ReadOnly = true;
            // 
            // gvLegit
            // 
            this.gvLegit.AllowUserToAddRows = false;
            this.gvLegit.AllowUserToDeleteRows = false;
            this.gvLegit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLegit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tokenLEGIT,
            this.propabilityLegit});
            this.gvLegit.Location = new System.Drawing.Point(277, 267);
            this.gvLegit.Name = "gvLegit";
            this.gvLegit.ReadOnly = true;
            this.gvLegit.Size = new System.Drawing.Size(255, 214);
            this.gvLegit.TabIndex = 1;
            // 
            // tokenLEGIT
            // 
            this.tokenLEGIT.HeaderText = "Token";
            this.tokenLEGIT.Name = "tokenLEGIT";
            this.tokenLEGIT.ReadOnly = true;
            // 
            // propabilityLegit
            // 
            this.propabilityLegit.HeaderText = "Propability";
            this.propabilityLegit.Name = "propabilityLegit";
            this.propabilityLegit.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CLASS - SPAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CLASS - LEGIT";
            // 
            // gvScore
            // 
            this.gvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassificationText,
            this.spamScore,
            this.legitScore});
            this.gvScore.Location = new System.Drawing.Point(12, 500);
            this.gvScore.Name = "gvScore";
            this.gvScore.Size = new System.Drawing.Size(520, 142);
            this.gvScore.TabIndex = 4;
            // 
            // ClassificationText
            // 
            this.ClassificationText.HeaderText = "TestText";
            this.ClassificationText.Name = "ClassificationText";
            // 
            // spamScore
            // 
            this.spamScore.HeaderText = "Spam score";
            this.spamScore.Name = "spamScore";
            // 
            // legitScore
            // 
            this.legitScore.HeaderText = "Legit score";
            this.legitScore.Name = "legitScore";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(7, 35);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // step2Btn
            // 
            this.step2Btn.Location = new System.Drawing.Point(107, 35);
            this.step2Btn.Name = "step2Btn";
            this.step2Btn.Size = new System.Drawing.Size(75, 23);
            this.step2Btn.TabIndex = 8;
            this.step2Btn.Text = "Step 2";
            this.step2Btn.UseVisualStyleBackColor = true;
            this.step2Btn.Click += new System.EventHandler(this.step2Btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectFolderBtn
            // 
            this.selectFolderBtn.Location = new System.Drawing.Point(220, 28);
            this.selectFolderBtn.Name = "selectFolderBtn";
            this.selectFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.selectFolderBtn.TabIndex = 10;
            this.selectFolderBtn.Text = "Select Folder";
            this.selectFolderBtn.UseVisualStyleBackColor = true;
            this.selectFolderBtn.Click += new System.EventHandler(this.selectFolderBtn_Click);
            // 
            // selectFolderTxt
            // 
            this.selectFolderTxt.Location = new System.Drawing.Point(12, 28);
            this.selectFolderTxt.Name = "selectFolderTxt";
            this.selectFolderTxt.Size = new System.Drawing.Size(191, 20);
            this.selectFolderTxt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select Pu Folder";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.step10Btn);
            this.groupBox1.Controls.Add(this.step9Btn);
            this.groupBox1.Controls.Add(this.step8Btn);
            this.groupBox1.Controls.Add(this.step7Btn);
            this.groupBox1.Controls.Add(this.step6Btn);
            this.groupBox1.Controls.Add(this.step5Btn);
            this.groupBox1.Controls.Add(this.step4Btn);
            this.groupBox1.Controls.Add(this.step3Btn);
            this.groupBox1.Controls.Add(this.startBtn);
            this.groupBox1.Controls.Add(this.step2Btn);
            this.groupBox1.Location = new System.Drawing.Point(17, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 102);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "10 Fold Cross Validation";
            // 
            // step10Btn
            // 
            this.step10Btn.Location = new System.Drawing.Point(406, 73);
            this.step10Btn.Name = "step10Btn";
            this.step10Btn.Size = new System.Drawing.Size(75, 23);
            this.step10Btn.TabIndex = 16;
            this.step10Btn.Text = "Step 10";
            this.step10Btn.UseVisualStyleBackColor = true;
            this.step10Btn.Click += new System.EventHandler(this.step10Btn_Click);
            // 
            // step9Btn
            // 
            this.step9Btn.Location = new System.Drawing.Point(306, 73);
            this.step9Btn.Name = "step9Btn";
            this.step9Btn.Size = new System.Drawing.Size(75, 23);
            this.step9Btn.TabIndex = 15;
            this.step9Btn.Text = "Step 9";
            this.step9Btn.UseVisualStyleBackColor = true;
            this.step9Btn.Click += new System.EventHandler(this.step9Btn_Click);
            // 
            // step8Btn
            // 
            this.step8Btn.Location = new System.Drawing.Point(206, 72);
            this.step8Btn.Name = "step8Btn";
            this.step8Btn.Size = new System.Drawing.Size(75, 23);
            this.step8Btn.TabIndex = 14;
            this.step8Btn.Text = "Step 8";
            this.step8Btn.UseVisualStyleBackColor = true;
            this.step8Btn.Click += new System.EventHandler(this.step8Btn_Click);
            // 
            // step7Btn
            // 
            this.step7Btn.Location = new System.Drawing.Point(106, 73);
            this.step7Btn.Name = "step7Btn";
            this.step7Btn.Size = new System.Drawing.Size(75, 23);
            this.step7Btn.TabIndex = 13;
            this.step7Btn.Text = "Step 7";
            this.step7Btn.UseVisualStyleBackColor = true;
            this.step7Btn.Click += new System.EventHandler(this.step7Btn_Click);
            // 
            // step6Btn
            // 
            this.step6Btn.Location = new System.Drawing.Point(6, 73);
            this.step6Btn.Name = "step6Btn";
            this.step6Btn.Size = new System.Drawing.Size(75, 23);
            this.step6Btn.TabIndex = 12;
            this.step6Btn.Text = "Step 6";
            this.step6Btn.UseVisualStyleBackColor = true;
            this.step6Btn.Click += new System.EventHandler(this.step6Btn_Click);
            // 
            // step5Btn
            // 
            this.step5Btn.Location = new System.Drawing.Point(407, 35);
            this.step5Btn.Name = "step5Btn";
            this.step5Btn.Size = new System.Drawing.Size(75, 23);
            this.step5Btn.TabIndex = 11;
            this.step5Btn.Text = "Step 5";
            this.step5Btn.UseVisualStyleBackColor = true;
            this.step5Btn.Click += new System.EventHandler(this.step5Btn_Click);
            // 
            // step4Btn
            // 
            this.step4Btn.Location = new System.Drawing.Point(307, 35);
            this.step4Btn.Name = "step4Btn";
            this.step4Btn.Size = new System.Drawing.Size(75, 23);
            this.step4Btn.TabIndex = 10;
            this.step4Btn.Text = "Step 4";
            this.step4Btn.UseVisualStyleBackColor = true;
            this.step4Btn.Click += new System.EventHandler(this.step4Btn_Click);
            // 
            // step3Btn
            // 
            this.step3Btn.Location = new System.Drawing.Point(207, 35);
            this.step3Btn.Name = "step3Btn";
            this.step3Btn.Size = new System.Drawing.Size(75, 23);
            this.step3Btn.TabIndex = 9;
            this.step3Btn.Text = "Step 3";
            this.step3Btn.UseVisualStyleBackColor = true;
            this.step3Btn.Click += new System.EventHandler(this.step3Btn_Click);
            // 
            // gvAverage
            // 
            this.gvAverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAverage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spamAverage,
            this.legitAverage});
            this.gvAverage.Location = new System.Drawing.Point(553, 267);
            this.gvAverage.Name = "gvAverage";
            this.gvAverage.Size = new System.Drawing.Size(312, 375);
            this.gvAverage.TabIndex = 14;
            // 
            // spamAverage
            // 
            this.spamAverage.HeaderText = "Spam Average";
            this.spamAverage.Name = "spamAverage";
            // 
            // legitAverage
            // 
            this.legitAverage.HeaderText = "Legit Average";
            this.legitAverage.Name = "legitAverage";
            // 
            // spamRecallLabel
            // 
            this.spamRecallLabel.AutoSize = true;
            this.spamRecallLabel.Location = new System.Drawing.Point(119, 27);
            this.spamRecallLabel.Name = "spamRecallLabel";
            this.spamRecallLabel.Size = new System.Drawing.Size(16, 13);
            this.spamRecallLabel.TabIndex = 16;
            this.spamRecallLabel.Text = "---";
            // 
            // spaPrecisionLabel5
            // 
            this.spaPrecisionLabel5.AutoSize = true;
            this.spaPrecisionLabel5.Location = new System.Drawing.Point(119, 69);
            this.spaPrecisionLabel5.Name = "spaPrecisionLabel5";
            this.spaPrecisionLabel5.Size = new System.Drawing.Size(16, 13);
            this.spaPrecisionLabel5.TabIndex = 17;
            this.spaPrecisionLabel5.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Spam Recall";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Spam Precision";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total spam messages";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Total messages identified as spam";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Correctly identified spam messages";
            // 
            // tspLBL
            // 
            this.tspLBL.AutoSize = true;
            this.tspLBL.Location = new System.Drawing.Point(213, 39);
            this.tspLBL.Name = "tspLBL";
            this.tspLBL.Size = new System.Drawing.Size(16, 13);
            this.tspLBL.TabIndex = 24;
            this.tspLBL.Text = "---";
            // 
            // msgIdAsSpam
            // 
            this.msgIdAsSpam.AutoSize = true;
            this.msgIdAsSpam.Location = new System.Drawing.Point(213, 69);
            this.msgIdAsSpam.Name = "msgIdAsSpam";
            this.msgIdAsSpam.Size = new System.Drawing.Size(16, 13);
            this.msgIdAsSpam.TabIndex = 25;
            this.msgIdAsSpam.Text = "---";
            // 
            // msgCorrectlyIdAsSpam
            // 
            this.msgCorrectlyIdAsSpam.AutoSize = true;
            this.msgCorrectlyIdAsSpam.Location = new System.Drawing.Point(213, 95);
            this.msgCorrectlyIdAsSpam.Name = "msgCorrectlyIdAsSpam";
            this.msgCorrectlyIdAsSpam.Size = new System.Drawing.Size(16, 13);
            this.msgCorrectlyIdAsSpam.TabIndex = 26;
            this.msgCorrectlyIdAsSpam.Text = "---";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.spaPrecisionLabel5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.spamRecallLabel);
            this.groupBox2.Location = new System.Drawing.Point(553, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.msgCorrectlyIdAsSpam);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.msgIdAsSpam);
            this.groupBox3.Controls.Add(this.tspLBL);
            this.groupBox3.Location = new System.Drawing.Point(553, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 151);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 654);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gvAverage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectFolderTxt);
            this.Controls.Add(this.selectFolderBtn);
            this.Controls.Add(this.gvScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvLegit);
            this.Controls.Add(this.gvSpam);
            this.Name = "Form1";
            this.Text = "Naive Bayes Text Classification";
            ((System.ComponentModel.ISupportInitialize)(this.gvSpam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLegit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvScore)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvAverage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvSpam;
        private System.Windows.Forms.DataGridView gvLegit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tokenSPAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn propabilitySPAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn tokenLEGIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn propabilityLegit;
        private System.Windows.Forms.DataGridView gvScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassificationText;
        private System.Windows.Forms.DataGridViewTextBoxColumn spamScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn legitScore;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button step2Btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectFolderBtn;
        private System.Windows.Forms.TextBox selectFolderTxt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button step10Btn;
        private System.Windows.Forms.Button step9Btn;
        private System.Windows.Forms.Button step8Btn;
        private System.Windows.Forms.Button step7Btn;
        private System.Windows.Forms.Button step6Btn;
        private System.Windows.Forms.Button step5Btn;
        private System.Windows.Forms.Button step4Btn;
        private System.Windows.Forms.Button step3Btn;
        private System.Windows.Forms.DataGridView gvAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn spamAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn legitAverage;
        private System.Windows.Forms.Label spamRecallLabel;
        private System.Windows.Forms.Label spaPrecisionLabel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tspLBL;
        private System.Windows.Forms.Label msgIdAsSpam;
        private System.Windows.Forms.Label msgCorrectlyIdAsSpam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

