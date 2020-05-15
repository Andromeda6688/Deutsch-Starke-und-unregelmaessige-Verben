namespace WindowsFormsApplication1
{
    partial class StarkeVerben
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
            this.tbPraesens = new System.Windows.Forms.TextBox();
            this.tbPraeteritum = new System.Windows.Forms.TextBox();
            this.tbPerfekt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHilfsverb = new System.Windows.Forms.TextBox();
            this.linkTip = new System.Windows.Forms.LinkLabel();
            this.btNext = new System.Windows.Forms.Button();
            this.lbTranslation = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btShowStatistics = new System.Windows.Forms.Button();
            this.lbVerbsLeft = new System.Windows.Forms.Label();
            this.btInsertAe = new System.Windows.Forms.Button();
            this.btInsertOe = new System.Windows.Forms.Button();
            this.btInsertUe = new System.Windows.Forms.Button();
            this.btInsertSs = new System.Windows.Forms.Button();
            this.lbScores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPraesens
            // 
            this.tbPraesens.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPraesens.Location = new System.Drawing.Point(12, 140);
            this.tbPraesens.Name = "tbPraesens";
            this.tbPraesens.Size = new System.Drawing.Size(300, 38);
            this.tbPraesens.TabIndex = 0;
            // 
            // tbPraeteritum
            // 
            this.tbPraeteritum.BackColor = System.Drawing.SystemColors.Window;
            this.tbPraeteritum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPraeteritum.Location = new System.Drawing.Point(318, 140);
            this.tbPraeteritum.Name = "tbPraeteritum";
            this.tbPraeteritum.Size = new System.Drawing.Size(200, 38);
            this.tbPraeteritum.TabIndex = 1;
            this.tbPraeteritum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPraeteritum_KeyUp);
            // 
            // tbPerfekt
            // 
            this.tbPerfekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPerfekt.Location = new System.Drawing.Point(630, 140);
            this.tbPerfekt.Name = "tbPerfekt";
            this.tbPerfekt.Size = new System.Drawing.Size(200, 38);
            this.tbPerfekt.TabIndex = 2;
            this.tbPerfekt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPerfekt_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Präsens:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(321, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Präteritum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(633, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Perfekt";
            // 
            // tbHilfsverb
            // 
            this.tbHilfsverb.BackColor = System.Drawing.SystemColors.Control;
            this.tbHilfsverb.Enabled = false;
            this.tbHilfsverb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHilfsverb.Location = new System.Drawing.Point(524, 140);
            this.tbHilfsverb.Name = "tbHilfsverb";
            this.tbHilfsverb.Size = new System.Drawing.Size(100, 38);
            this.tbHilfsverb.TabIndex = 2;
            // 
            // linkTip
            // 
            this.linkTip.AutoSize = true;
            this.linkTip.Location = new System.Drawing.Point(370, 261);
            this.linkTip.Name = "linkTip";
            this.linkTip.Size = new System.Drawing.Size(74, 13);
            this.linkTip.TabIndex = 4;
            this.linkTip.TabStop = true;
            this.linkTip.Text = "Show me a tip";
            this.linkTip.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTip_LinkClicked);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(332, 283);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(145, 44);
            this.btNext.TabIndex = 5;
            this.btNext.Text = "Ok";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // lbTranslation
            // 
            this.lbTranslation.AutoSize = true;
            this.lbTranslation.Location = new System.Drawing.Point(19, 198);
            this.lbTranslation.Name = "lbTranslation";
            this.lbTranslation.Size = new System.Drawing.Size(0, 13);
            this.lbTranslation.TabIndex = 6;
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btShowStatistics
            // 
            this.btShowStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btShowStatistics.Location = new System.Drawing.Point(12, 21);
            this.btShowStatistics.Name = "btShowStatistics";
            this.btShowStatistics.Size = new System.Drawing.Size(35, 35);
            this.btShowStatistics.TabIndex = 7;
            this.btShowStatistics.Text = "★";
            this.btShowStatistics.UseVisualStyleBackColor = true;
            this.btShowStatistics.Click += new System.EventHandler(this.btShowStatistics_Click);
            // 
            // lbVerbsLeft
            // 
            this.lbVerbsLeft.AutoSize = true;
            this.lbVerbsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVerbsLeft.Location = new System.Drawing.Point(75, 39);
            this.lbVerbsLeft.Name = "lbVerbsLeft";
            this.lbVerbsLeft.Size = new System.Drawing.Size(30, 24);
            this.lbVerbsLeft.TabIndex = 9;
            this.lbVerbsLeft.Text = "21";
            // 
            // btInsertAe
            // 
            this.btInsertAe.Location = new System.Drawing.Point(836, 120);
            this.btInsertAe.Name = "btInsertAe";
            this.btInsertAe.Size = new System.Drawing.Size(21, 21);
            this.btInsertAe.TabIndex = 10;
            this.btInsertAe.Text = "ä";
            this.btInsertAe.UseVisualStyleBackColor = true;
            this.btInsertAe.Click += new System.EventHandler(this.btInsertAe_Click);
            // 
            // btInsertOe
            // 
            this.btInsertOe.Location = new System.Drawing.Point(836, 140);
            this.btInsertOe.Name = "btInsertOe";
            this.btInsertOe.Size = new System.Drawing.Size(21, 21);
            this.btInsertOe.TabIndex = 10;
            this.btInsertOe.Text = "ö";
            this.btInsertOe.UseVisualStyleBackColor = true;
            this.btInsertOe.Click += new System.EventHandler(this.btInsertOe_Click);
            // 
            // btInsertUe
            // 
            this.btInsertUe.Location = new System.Drawing.Point(836, 160);
            this.btInsertUe.Name = "btInsertUe";
            this.btInsertUe.Size = new System.Drawing.Size(21, 21);
            this.btInsertUe.TabIndex = 10;
            this.btInsertUe.Text = "ü";
            this.btInsertUe.UseVisualStyleBackColor = true;
            this.btInsertUe.Click += new System.EventHandler(this.btInsertUe_Click);
            // 
            // btInsertSs
            // 
            this.btInsertSs.Location = new System.Drawing.Point(836, 180);
            this.btInsertSs.Name = "btInsertSs";
            this.btInsertSs.Size = new System.Drawing.Size(21, 21);
            this.btInsertSs.TabIndex = 10;
            this.btInsertSs.Text = "ß";
            this.btInsertSs.UseVisualStyleBackColor = true;
            this.btInsertSs.Click += new System.EventHandler(this.btInsertSs_Click);
            // 
            // lbScores
            // 
            this.lbScores.AutoSize = true;
            this.lbScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbScores.Location = new System.Drawing.Point(78, 15);
            this.lbScores.Name = "lbScores";
            this.lbScores.Size = new System.Drawing.Size(20, 24);
            this.lbScores.TabIndex = 12;
            this.lbScores.Text = "0";
            // 
            // StarkeVerben
            // 
            this.AcceptButton = this.btNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lbScores);
            this.Controls.Add(this.btInsertSs);
            this.Controls.Add(this.btInsertUe);
            this.Controls.Add(this.btInsertOe);
            this.Controls.Add(this.btInsertAe);
            this.Controls.Add(this.lbVerbsLeft);
            this.Controls.Add(this.btShowStatistics);
            this.Controls.Add(this.lbTranslation);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.linkTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHilfsverb);
            this.Controls.Add(this.tbPerfekt);
            this.Controls.Add(this.tbPraeteritum);
            this.Controls.Add(this.tbPraesens);
            this.Name = "StarkeVerben";
            this.Text = "Starke und unregelmäßige Verben";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPraesens;
        private System.Windows.Forms.TextBox tbPraeteritum;
        private System.Windows.Forms.TextBox tbPerfekt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHilfsverb;
        private System.Windows.Forms.LinkLabel linkTip;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Label lbTranslation;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btShowStatistics;
        private System.Windows.Forms.Label lbVerbsLeft;
        private System.Windows.Forms.Button btInsertAe;
        private System.Windows.Forms.Button btInsertOe;
        private System.Windows.Forms.Button btInsertUe;
        private System.Windows.Forms.Button btInsertSs;
        private System.Windows.Forms.Label lbScores;
    }
}

