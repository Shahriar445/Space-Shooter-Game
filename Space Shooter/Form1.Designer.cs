using System;

namespace Space_Shooter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoveBgTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.RightMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.UpMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.DownMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveMinutionTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveEnemiTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemiesMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.Labelbtn = new System.Windows.Forms.Label();
            this.Replaybtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.labl = new System.Windows.Forms.Label();
            this.sdf = new System.Windows.Forms.Label();
            this.ScoreUp = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBgTimer
            // 
            this.MoveBgTimer.Enabled = true;
            this.MoveBgTimer.Interval = 10;
            this.MoveBgTimer.Tick += new System.EventHandler(this.MoveBgTimer_Tick_1);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(260, 400);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RightMoveTimer
            // 
            this.RightMoveTimer.Interval = 5;
            this.RightMoveTimer.Tick += new System.EventHandler(this.RightMoveTimer_Tick);
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Interval = 5;
            this.LeftMoveTimer.Tick += new System.EventHandler(this.LeftMoveTimer_Tick);
            // 
            // UpMoveTimer
            // 
            this.UpMoveTimer.Interval = 5;
            this.UpMoveTimer.Tick += new System.EventHandler(this.UpMoveTimer_Tick);
            // 
            // DownMoveTimer
            // 
            this.DownMoveTimer.Interval = 5;
            this.DownMoveTimer.Tick += new System.EventHandler(this.DownMoveTimer_Tick);
            // 
            // MoveMinutionTimer
            // 
            this.MoveMinutionTimer.Enabled = true;
            this.MoveMinutionTimer.Interval = 20;
            this.MoveMinutionTimer.Tick += new System.EventHandler(this.MoveMinutionTimer_Tick);
            // 
            // MoveEnemiTimer
            // 
            this.MoveEnemiTimer.Enabled = true;
            this.MoveEnemiTimer.Tick += new System.EventHandler(this.MoveEnemiTimer_Tick);
            // 
            // EnemiesMunitionTimer
            // 
            this.EnemiesMunitionTimer.Enabled = true;
            this.EnemiesMunitionTimer.Interval = 20;
            this.EnemiesMunitionTimer.Tick += new System.EventHandler(this.EnemiesMunitionTimer_Tick);
            // 
            // Labelbtn
            // 
            this.Labelbtn.AutoSize = true;
            this.Labelbtn.Font = new System.Drawing.Font("Algerian", 35.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelbtn.ForeColor = System.Drawing.Color.Magenta;
            this.Labelbtn.Location = new System.Drawing.Point(190, 118);
            this.Labelbtn.Name = "Labelbtn";
            this.Labelbtn.Size = new System.Drawing.Size(210, 53);
            this.Labelbtn.TabIndex = 1;
            this.Labelbtn.Text = "LABEL 1";
            this.Labelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Labelbtn.Visible = false;
            // 
            // Replaybtn
            // 
            this.Replaybtn.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replaybtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.Replaybtn.Location = new System.Drawing.Point(182, 188);
            this.Replaybtn.Name = "Replaybtn";
            this.Replaybtn.Size = new System.Drawing.Size(204, 44);
            this.Replaybtn.TabIndex = 2;
            this.Replaybtn.Text = "Replay";
            this.Replaybtn.UseVisualStyleBackColor = true;
            this.Replaybtn.Visible = false;
            this.Replaybtn.Click += new System.EventHandler(this.Replaybtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exitbtn.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.Color.Red;
            this.Exitbtn.Location = new System.Drawing.Point(183, 238);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(203, 38);
            this.Exitbtn.TabIndex = 3;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Visible = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl.ForeColor = System.Drawing.Color.Gold;
            this.labl.Location = new System.Drawing.Point(451, 9);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(86, 28);
            this.labl.TabIndex = 4;
            this.labl.Text = "Label :";
            // 
            // sdf
            // 
            this.sdf.AutoSize = true;
            this.sdf.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdf.ForeColor = System.Drawing.Color.OrangeRed;
            this.sdf.Location = new System.Drawing.Point(-1, 9);
            this.sdf.Name = "sdf";
            this.sdf.Size = new System.Drawing.Size(100, 28);
            this.sdf.TabIndex = 5;
            this.sdf.Text = "Score : ";
            // 
            // ScoreUp
            // 
            this.ScoreUp.AutoSize = true;
            this.ScoreUp.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ScoreUp.ForeColor = System.Drawing.Color.Red;
            this.ScoreUp.Location = new System.Drawing.Point(83, 12);
            this.ScoreUp.Name = "ScoreUp";
            this.ScoreUp.Size = new System.Drawing.Size(44, 28);
            this.ScoreUp.TabIndex = 6;
            this.ScoreUp.Text = "00";
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelUpdate.ForeColor = System.Drawing.Color.Gold;
            this.labelUpdate.Location = new System.Drawing.Point(532, 9);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(28, 28);
            this.labelUpdate.TabIndex = 7;
            this.labelUpdate.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.ScoreUp);
            this.Controls.Add(this.sdf);
            this.Controls.Add(this.labl);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Replaybtn);
            this.Controls.Add(this.Labelbtn);
            this.Controls.Add(this.Player);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Space Shooter";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Timer MoveBgTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer UpMoveTimer;
        private System.Windows.Forms.Timer DownMoveTimer;
        private System.Windows.Forms.Timer MoveMinutionTimer;
        private System.Windows.Forms.Timer MoveEnemiTimer;
        private System.Windows.Forms.Timer EnemiesMunitionTimer;
        private System.Windows.Forms.Label Labelbtn;
        private System.Windows.Forms.Button Replaybtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.Label sdf;
        private System.Windows.Forms.Label ScoreUp;
        private System.Windows.Forms.Label labelUpdate;
    }
}

