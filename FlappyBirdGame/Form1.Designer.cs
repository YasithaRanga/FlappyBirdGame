
namespace FlappyBirdGame
{
    partial class FlappyBirdGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBirdGame));
            this.Bird = new Guna.UI.WinForms.GunaPictureBox();
            this.ground = new Guna.UI.WinForms.GunaPictureBox();
            this.pipeDown = new Guna.UI.WinForms.GunaPictureBox();
            this.pipeUp = new Guna.UI.WinForms.GunaPictureBox();
            this.lblScore = new Guna.UI.WinForms.GunaLabel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new Guna.UI.WinForms.GunaLabel();
            this.lblRestart = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            this.SuspendLayout();
            // 
            // Bird
            // 
            this.Bird.BackColor = System.Drawing.Color.Transparent;
            this.Bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Bird.BaseColor = System.Drawing.Color.White;
            this.Bird.Image = ((System.Drawing.Image)(resources.GetObject("Bird.Image")));
            this.Bird.Location = new System.Drawing.Point(162, 162);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(46, 38);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bird.TabIndex = 0;
            this.Bird.TabStop = false;
            this.Bird.UseTransfarantBackground = true;
            this.Bird.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // ground
            // 
            this.ground.BaseColor = System.Drawing.Color.White;
            this.ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(0, 383);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(837, 65);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.BackColor = System.Drawing.Color.Transparent;
            this.pipeDown.BaseColor = System.Drawing.Color.White;
            this.pipeDown.Image = ((System.Drawing.Image)(resources.GetObject("pipeDown.Image")));
            this.pipeDown.Location = new System.Drawing.Point(448, 264);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(84, 156);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 2;
            this.pipeDown.TabStop = false;
            // 
            // pipeUp
            // 
            this.pipeUp.BackColor = System.Drawing.Color.Transparent;
            this.pipeUp.BaseColor = System.Drawing.Color.White;
            this.pipeUp.Image = ((System.Drawing.Image)(resources.GetObject("pipeUp.Image")));
            this.pipeUp.Location = new System.Drawing.Point(513, 1);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(84, 127);
            this.pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp.TabIndex = 3;
            this.pipeUp.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(123, 40);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: ";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Cyan;
            this.lblGameOver.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblGameOver.Location = new System.Drawing.Point(269, 162);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(0, 71);
            this.lblGameOver.TabIndex = 5;
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.BackColor = System.Drawing.Color.Cyan;
            this.lblRestart.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRestart.Location = new System.Drawing.Point(241, 275);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(0, 37);
            this.lblRestart.TabIndex = 5;
            // 
            // FlappyBirdGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(837, 448);
            this.Controls.Add(this.lblRestart);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.pipeUp);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeDown);
            this.Name = "FlappyBirdGame";
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Restart);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.birdUp);
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaPictureBox ground;
        private Guna.UI.WinForms.GunaPictureBox pipeDown;
        private Guna.UI.WinForms.GunaPictureBox pipeUp;
        private Guna.UI.WinForms.GunaLabel lblScore;
        private System.Windows.Forms.Timer Timer;
        private Guna.UI.WinForms.GunaPictureBox Bird;
        private Guna.UI.WinForms.GunaLabel lblGameOver;
        private Guna.UI.WinForms.GunaLabel lblRestart;
    }
}

