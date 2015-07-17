/*  - Copyright 2007 
    - Steven Lavoie 
    - axessterminated@gmail.com
    - www.etheism.org
    This program is free software and may be used and distributed as outlined
    by the CodeProject Open License 1.0, found here: 
    http://www.codeproject.com/info/cpol10.aspx.
  
    The main points subject to the terms of the License are:
    * Source Code and Executable Files can be used in commercial applications;
    * Source Code and Executable Files can be redistributed; and
    * Source Code can be modified to create derivative works.
    * No claim of suitability, guarantee, or any warranty whatsoever is provided. The software is provided "as-is".
*/
namespace BattleForm
{
    partial class frmBattle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBattle));
            this.tabctlOptions = new System.Windows.Forms.TabControl();
            this.tabAttack = new System.Windows.Forms.TabPage();
            this.btnAttack3 = new System.Windows.Forms.Button();
            this.btnAttack4 = new System.Windows.Forms.Button();
            this.btnAttack2 = new System.Windows.Forms.Button();
            this.btnAttack1 = new System.Windows.Forms.Button();
            this.tabPack = new System.Windows.Forms.TabPage();
            this.tooledjimon = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pictureboxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureboxEnemy = new System.Windows.Forms.PictureBox();
            this.titlebar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerType = new System.Windows.Forms.Label();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.lblEnemyType = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFlee = new System.Windows.Forms.Button();
            this.txtBattleSummary = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabctlOptions.SuspendLayout();
            this.tabAttack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlebar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctlOptions
            // 
            this.tabctlOptions.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabctlOptions.Controls.Add(this.tabAttack);
            this.tabctlOptions.Controls.Add(this.tabPack);
            this.tabctlOptions.HotTrack = true;
            this.tabctlOptions.Location = new System.Drawing.Point(0, 250);
            this.tabctlOptions.Name = "tabctlOptions";
            this.tabctlOptions.SelectedIndex = 0;
            this.tabctlOptions.ShowToolTips = true;
            this.tabctlOptions.Size = new System.Drawing.Size(344, 202);
            this.tabctlOptions.TabIndex = 1;
            // 
            // tabAttack
            // 
            this.tabAttack.Controls.Add(this.btnAttack3);
            this.tabAttack.Controls.Add(this.btnAttack4);
            this.tabAttack.Controls.Add(this.btnAttack2);
            this.tabAttack.Controls.Add(this.btnAttack1);
            this.tabAttack.Location = new System.Drawing.Point(4, 24);
            this.tabAttack.Name = "tabAttack";
            this.tabAttack.Padding = new System.Windows.Forms.Padding(3);
            this.tabAttack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabAttack.Size = new System.Drawing.Size(336, 174);
            this.tabAttack.TabIndex = 0;
            this.tabAttack.Text = "Attack";
            this.tabAttack.ToolTipText = "Attack your opponent!";
            this.tabAttack.UseVisualStyleBackColor = true;
            // 
            // btnAttack3
            // 
            this.btnAttack3.Enabled = false;
            this.btnAttack3.Location = new System.Drawing.Point(93, 94);
            this.btnAttack3.Name = "btnAttack3";
            this.btnAttack3.Size = new System.Drawing.Size(150, 23);
            this.btnAttack3.TabIndex = 3;
            this.btnAttack3.UseVisualStyleBackColor = true;
            this.btnAttack3.Visible = false;
            // 
            // btnAttack4
            // 
            this.btnAttack4.Enabled = false;
            this.btnAttack4.Location = new System.Drawing.Point(93, 131);
            this.btnAttack4.Name = "btnAttack4";
            this.btnAttack4.Size = new System.Drawing.Size(150, 23);
            this.btnAttack4.TabIndex = 2;
            this.btnAttack4.UseVisualStyleBackColor = true;
            this.btnAttack4.Visible = false;
            // 
            // btnAttack2
            // 
            this.btnAttack2.Enabled = false;
            this.btnAttack2.Location = new System.Drawing.Point(93, 57);
            this.btnAttack2.Name = "btnAttack2";
            this.btnAttack2.Size = new System.Drawing.Size(150, 23);
            this.btnAttack2.TabIndex = 1;
            this.btnAttack2.UseVisualStyleBackColor = true;
            this.btnAttack2.Visible = false;
            // 
            // btnAttack1
            // 
            this.btnAttack1.Enabled = false;
            this.btnAttack1.Location = new System.Drawing.Point(93, 20);
            this.btnAttack1.Name = "btnAttack1";
            this.btnAttack1.Size = new System.Drawing.Size(150, 23);
            this.btnAttack1.TabIndex = 0;
            this.btnAttack1.UseVisualStyleBackColor = true;
            this.btnAttack1.Visible = false;
            this.btnAttack1.Click += new System.EventHandler(this.btnAttack1_Click);
            // 
            // tabPack
            // 
            this.tabPack.Location = new System.Drawing.Point(4, 24);
            this.tabPack.Name = "tabPack";
            this.tabPack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPack.Size = new System.Drawing.Size(336, 174);
            this.tabPack.TabIndex = 1;
            this.tabPack.Text = "Pack";
            this.tabPack.ToolTipText = "View your pack contents.";
            this.tabPack.UseVisualStyleBackColor = true;
            // 
            // tooledjimon
            // 
            this.tooledjimon.BackColor = System.Drawing.Color.SteelBlue;
            this.tooledjimon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tooledjimon.Location = new System.Drawing.Point(0, 455);
            this.tooledjimon.Name = "tooledjimon";
            this.tooledjimon.Size = new System.Drawing.Size(660, 25);
            this.tooledjimon.TabIndex = 2;
            this.tooledjimon.Text = "Edjimon";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // pictureboxPlayer
            // 
            this.pictureboxPlayer.Location = new System.Drawing.Point(3, 274);
            this.pictureboxPlayer.Name = "pictureboxPlayer";
            this.pictureboxPlayer.Size = new System.Drawing.Size(135, 135);
            this.pictureboxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxPlayer.TabIndex = 4;
            this.pictureboxPlayer.TabStop = false;
            // 
            // pictureboxEnemy
            // 
            this.pictureboxEnemy.Location = new System.Drawing.Point(164, 3);
            this.pictureboxEnemy.Name = "pictureboxEnemy";
            this.pictureboxEnemy.Size = new System.Drawing.Size(135, 135);
            this.pictureboxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxEnemy.TabIndex = 3;
            this.pictureboxEnemy.TabStop = false;
            // 
            // titlebar
            // 
            this.titlebar.Image = ((System.Drawing.Image)(resources.GetObject("titlebar.Image")));
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(660, 30);
            this.titlebar.TabIndex = 0;
            this.titlebar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbPlayerHP);
            this.panel1.Controls.Add(this.pbEnemyHP);
            this.panel1.Controls.Add(this.lblPlayerName);
            this.panel1.Controls.Add(this.lblPlayerType);
            this.panel1.Controls.Add(this.lblEnemyName);
            this.panel1.Controls.Add(this.lblEnemyType);
            this.panel1.Controls.Add(this.pictureboxEnemy);
            this.panel1.Controls.Add(this.pictureboxPlayer);
            this.panel1.Location = new System.Drawing.Point(346, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 412);
            this.panel1.TabIndex = 5;
            // 
            // pbPlayerHP
            // 
            this.pbPlayerHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayerHP.Location = new System.Drawing.Point(148, 401);
            this.pbPlayerHP.Maximum = 100;
            this.pbPlayerHP.Minimum = 0;
            this.pbPlayerHP.Name = "pbPlayerHP";
            this.pbPlayerHP.ProgressBarColor = System.Drawing.Color.Lime;
            this.pbPlayerHP.Size = new System.Drawing.Size(151, 8);
            this.pbPlayerHP.TabIndex = 10;
            this.pbPlayerHP.Value = 45;
            // 
            // pbEnemyHP
            // 
            this.pbEnemyHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEnemyHP.Location = new System.Drawing.Point(3, 3);
            this.pbEnemyHP.Maximum = 100;
            this.pbEnemyHP.Minimum = 0;
            this.pbEnemyHP.Name = "pbEnemyHP";
            this.pbEnemyHP.ProgressBarColor = System.Drawing.Color.Lime;
            this.pbEnemyHP.Size = new System.Drawing.Size(151, 8);
            this.pbEnemyHP.TabIndex = 9;
            this.pbEnemyHP.Value = 45;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(4, 242);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerName.TabIndex = 8;
            // 
            // lblPlayerType
            // 
            this.lblPlayerType.AutoSize = true;
            this.lblPlayerType.Location = new System.Drawing.Point(4, 258);
            this.lblPlayerType.Name = "lblPlayerType";
            this.lblPlayerType.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerType.TabIndex = 7;
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.Location = new System.Drawing.Point(161, 141);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(0, 13);
            this.lblEnemyName.TabIndex = 6;
            // 
            // lblEnemyType
            // 
            this.lblEnemyType.AutoSize = true;
            this.lblEnemyType.Location = new System.Drawing.Point(161, 154);
            this.lblEnemyType.Name = "lblEnemyType";
            this.lblEnemyType.Size = new System.Drawing.Size(0, 13);
            this.lblEnemyType.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(632, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 20);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFlee
            // 
            this.btnFlee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFlee.Location = new System.Drawing.Point(290, 250);
            this.btnFlee.Name = "btnFlee";
            this.btnFlee.Size = new System.Drawing.Size(49, 20);
            this.btnFlee.TabIndex = 7;
            this.btnFlee.Text = "Flee";
            this.btnFlee.UseVisualStyleBackColor = true;
            this.btnFlee.Click += new System.EventHandler(this.btnFlee_Click);
            // 
            // txtBattleSummary
            // 
            this.txtBattleSummary.Location = new System.Drawing.Point(8, 55);
            this.txtBattleSummary.Name = "txtBattleSummary";
            this.txtBattleSummary.ReadOnly = true;
            this.txtBattleSummary.Size = new System.Drawing.Size(332, 189);
            this.txtBattleSummary.TabIndex = 8;
            this.txtBattleSummary.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Battle Summary";
            // 
            // frmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBattleSummary);
            this.Controls.Add(this.btnFlee);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tooledjimon);
            this.Controls.Add(this.titlebar);
            this.Controls.Add(this.tabctlOptions);
            this.Font = new System.Drawing.Font("MS Gothic", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBattle";
            this.tabctlOptions.ResumeLayout(false);
            this.tabAttack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlebar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox titlebar;
        private System.Windows.Forms.TabControl tabctlOptions;
        private System.Windows.Forms.TabPage tabAttack;
        private System.Windows.Forms.TabPage tabPack;
        private System.Windows.Forms.ToolStrip tooledjimon;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox pictureboxEnemy;
        private System.Windows.Forms.PictureBox pictureboxPlayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFlee;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerType;
        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.Label lblEnemyType;
        private System.Windows.Forms.Button btnAttack3;
        private System.Windows.Forms.Button btnAttack4;
        private System.Windows.Forms.Button btnAttack2;
        private System.Windows.Forms.Button btnAttack1;
        private SmoothProgressBar.SmoothProgressBar pbEnemyHP = new SmoothProgressBar.SmoothProgressBar(); //added 16Jul15 due to null error. may not be the best idea but it works for now
        private SmoothProgressBar.SmoothProgressBar pbPlayerHP = new SmoothProgressBar.SmoothProgressBar(); //added 16Jul15 due to null error. may not be the best idea but it works for now
        private System.Windows.Forms.RichTextBox txtBattleSummary;
        private System.Windows.Forms.Label label1;
    }
}