using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace Suburb_of_Military_Fighting_Vehicles_Online
{
    partial class frmTanks : System.Windows.Forms.Form
    {

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        //Required by the Windows Form Designer

        private System.ComponentModel.IContainer components;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.pctObstacle = new System.Windows.Forms.PictureBox();
            this.pctTankTwo = new System.Windows.Forms.PictureBox();
            this.pctTank1 = new System.Windows.Forms.PictureBox();
            this.MenuStrip2 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pctObstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTankTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTank1)).BeginInit();
            this.MenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pctObstacle
            // 
            this.pctObstacle.Image = global::Suburb_of_Military_Fighting_Vehicles_Online.Properties.Resources.Obstacle;
            this.pctObstacle.Location = new System.Drawing.Point(543, 256);
            this.pctObstacle.Name = "pctObstacle";
            this.pctObstacle.Size = new System.Drawing.Size(174, 174);
            this.pctObstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctObstacle.TabIndex = 4;
            this.pctObstacle.TabStop = false;
            // 
            // pctTankTwo
            // 
            this.pctTankTwo.Image = global::Suburb_of_Military_Fighting_Vehicles_Online.Properties.Resources.GreenTankUp;
            this.pctTankTwo.Location = new System.Drawing.Point(12, 530);
            this.pctTankTwo.Name = "pctTankTwo";
            this.pctTankTwo.Size = new System.Drawing.Size(100, 100);
            this.pctTankTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTankTwo.TabIndex = 1;
            this.pctTankTwo.TabStop = false;
            // 
            // pctTank1
            // 
            this.pctTank1.Image = global::Suburb_of_Military_Fighting_Vehicles_Online.Properties.Resources.SovietTankUp;
            this.pctTank1.Location = new System.Drawing.Point(1172, 530);
            this.pctTank1.Name = "pctTank1";
            this.pctTank1.Size = new System.Drawing.Size(100, 100);
            this.pctTank1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTank1.TabIndex = 0;
            this.pctTank1.TabStop = false;
            // 
            // MenuStrip2
            // 
            this.MenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.onlineToolStripMenuItem,
            this.cheatsToolStripMenuItem});
            this.MenuStrip2.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip2.Name = "MenuStrip2";
            this.MenuStrip2.Size = new System.Drawing.Size(1284, 24);
            this.MenuStrip2.TabIndex = 5;
            this.MenuStrip2.Text = "MenuStrip2";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // onlineToolStripMenuItem
            // 
            this.onlineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startServerToolStripMenuItem,
            this.connectToolStripMenuItem});
            this.onlineToolStripMenuItem.Name = "onlineToolStripMenuItem";
            this.onlineToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.onlineToolStripMenuItem.Text = "Online";
            // 
            // startServerToolStripMenuItem
            // 
            this.startServerToolStripMenuItem.Name = "startServerToolStripMenuItem";
            this.startServerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startServerToolStripMenuItem.Text = "Start Server";
            this.startServerToolStripMenuItem.Click += new System.EventHandler(this.startServerToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // cheatsToolStripMenuItem
            // 
            this.cheatsToolStripMenuItem.Name = "cheatsToolStripMenuItem";
            this.cheatsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cheatsToolStripMenuItem.Text = "Cheats";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.Location = new System.Drawing.Point(1223, 38);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(50, 18);
            this.lblScore1.TabIndex = 7;
            this.lblScore1.Text = "Score";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.Location = new System.Drawing.Point(9, 38);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(50, 18);
            this.lblScore2.TabIndex = 8;
            this.lblScore2.Text = "Score";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // frmTanks
            // 
            this.ClientSize = new System.Drawing.Size(1284, 642);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.pctTankTwo);
            this.Controls.Add(this.pctTank1);
            this.Controls.Add(this.pctObstacle);
            this.Controls.Add(this.MenuStrip2);
            this.MainMenuStrip = this.MenuStrip2;
            this.Name = "frmTanks";
            this.Text = "Tanks";
            ((System.ComponentModel.ISupportInitialize)(this.pctObstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTankTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTank1)).EndInit();
            this.MenuStrip2.ResumeLayout(false);
            this.MenuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.PictureBox pctTank;
        internal System.Windows.Forms.PictureBox pctTank2;
        internal System.Windows.Forms.PictureBox pctBullet1;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblLives1;
        internal System.Windows.Forms.Label lblLives2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ToolStripMenuItem PlayToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MultiplayerToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SinglplayerToolStripMenuItem;
        internal System.Windows.Forms.PictureBox pctBullet2;
        internal System.Windows.Forms.PictureBox pctTank1;
        internal System.Windows.Forms.PictureBox pctTankTwo;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.PictureBox pctObstacle;
        internal System.Windows.Forms.MenuStrip MenuStrip2;
        internal System.Windows.Forms.Label lblScore1;
        internal System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.ToolStripMenuItem onlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
    }
}