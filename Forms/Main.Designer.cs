﻿namespace clickerheroes.autoplayer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.parsegame = new System.Windows.Forms.Timer(this.components);
            this.lblParseTime = new System.Windows.Forms.Label();
            this.lblCurrMoney = new System.Windows.Forms.Label();
            this.curHeroesTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCursorPos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.useskills = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.lblCurrGoal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clickerHeroesPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txbLog = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 128);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // parsegame
            // 
            this.parsegame.Interval = 1000;
            this.parsegame.Tick += new System.EventHandler(this.clickyclicky_Tick);
            // 
            // lblParseTime
            // 
            this.lblParseTime.AutoSize = true;
            this.lblParseTime.Location = new System.Drawing.Point(89, 52);
            this.lblParseTime.Name = "lblParseTime";
            this.lblParseTime.Size = new System.Drawing.Size(24, 13);
            this.lblParseTime.TabIndex = 9;
            this.lblParseTime.Text = "n/a";
            // 
            // lblCurrMoney
            // 
            this.lblCurrMoney.AutoSize = true;
            this.lblCurrMoney.Location = new System.Drawing.Point(90, 78);
            this.lblCurrMoney.Name = "lblCurrMoney";
            this.lblCurrMoney.Size = new System.Drawing.Size(24, 13);
            this.lblCurrMoney.TabIndex = 10;
            this.lblCurrMoney.Text = "n/a";
            // 
            // curHeroesTxt
            // 
            this.curHeroesTxt.Location = new System.Drawing.Point(11, 166);
            this.curHeroesTxt.Multiline = true;
            this.curHeroesTxt.Name = "curHeroesTxt";
            this.curHeroesTxt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.curHeroesTxt.Size = new System.Drawing.Size(305, 123);
            this.curHeroesTxt.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Parse Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Current Money";
            // 
            // lblCursorPos
            // 
            this.lblCursorPos.AutoSize = true;
            this.lblCursorPos.ForeColor = System.Drawing.Color.Black;
            this.lblCursorPos.Location = new System.Drawing.Point(89, 29);
            this.lblCursorPos.Name = "lblCursorPos";
            this.lblCursorPos.Size = new System.Drawing.Size(24, 13);
            this.lblCursorPos.TabIndex = 1;
            this.lblCursorPos.Text = "n/a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cursor position";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Current Heroes";
            // 
            // useskills
            // 
            this.useskills.Interval = 2000;
            this.useskills.Tick += new System.EventHandler(this.useskills_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Current Goal";
            // 
            // lblCurrGoal
            // 
            this.lblCurrGoal.AutoSize = true;
            this.lblCurrGoal.Location = new System.Drawing.Point(90, 102);
            this.lblCurrGoal.Name = "lblCurrGoal";
            this.lblCurrGoal.Size = new System.Drawing.Size(24, 13);
            this.lblCurrGoal.TabIndex = 18;
            this.lblCurrGoal.Text = "n/a";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "n/a";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickerHeroesPositionToolStripMenuItem,
            this.taskListToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Settings";
            // 
            // clickerHeroesPositionToolStripMenuItem
            // 
            this.clickerHeroesPositionToolStripMenuItem.Name = "clickerHeroesPositionToolStripMenuItem";
            this.clickerHeroesPositionToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.clickerHeroesPositionToolStripMenuItem.Text = "Clicker Heroes Position";
            this.clickerHeroesPositionToolStripMenuItem.Click += new System.EventHandler(this.clickerHeroesPositionToolStripMenuItem_Click);
            // 
            // taskListToolStripMenuItem
            // 
            this.taskListToolStripMenuItem.Name = "taskListToolStripMenuItem";
            this.taskListToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.taskListToolStripMenuItem.Text = "Task List";
            this.taskListToolStripMenuItem.Click += new System.EventHandler(this.heroBuyOrderToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.otherToolStripMenuItem.Text = "Other";
            this.otherToolStripMenuItem.Click += new System.EventHandler(this.otherToolStripMenuItem_Click);
            // 
            // txbLog
            // 
            this.txbLog.Location = new System.Drawing.Point(322, 26);
            this.txbLog.Multiline = true;
            this.txbLog.Name = "txbLog";
            this.txbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbLog.Size = new System.Drawing.Size(400, 397);
            this.txbLog.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 435);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblCurrGoal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbLog);
            this.Controls.Add(this.curHeroesTxt);
            this.Controls.Add(this.lblCurrMoney);
            this.Controls.Add(this.lblParseTime);
            this.Controls.Add(this.lblCursorPos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "AutoPlayer Clicker Heroes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer parsegame;
        private System.Windows.Forms.Label lblParseTime;
        private System.Windows.Forms.Label lblCurrMoney;
        private System.Windows.Forms.TextBox curHeroesTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCursorPos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer useskills;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCurrGoal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clickerHeroesPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.TextBox txbLog;
    }
}

