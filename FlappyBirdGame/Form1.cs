using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class FlappyBirdGame : Form
    {
        public FlappyBirdGame()
        {
            InitializeComponent();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        int pipeSpeed = 10;
        int gravity = 10;
        int score = 0;

        private void TimerEvent(object sender, EventArgs e)
        {
            pipeUp.Left -= pipeSpeed;
            pipeDown.Left -= pipeSpeed;
            Bird.Top += gravity;
            if (pipeDown.Left < 0)
            {
                pipeDown.Left = 800;
                score++;
                lblScore.Text = ("Score: " + score);
            }
            if (pipeUp.Left < 0)
            {
                pipeUp.Left = 950;
            }
            if (Bird.Bounds.IntersectsWith(pipeDown.Bounds))
            {
                gameOver();
            }
            if (Bird.Bounds.IntersectsWith(pipeUp.Bounds))
            {
                gameOver();
            }
            if (Bird.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver();
            }
        }

        public void gameOver()
        {
            Timer.Stop();
            lblGameOver.Text = ("Game Over");
            lblRestart.Text = ("Press Enter to Start Again!");

        }
        
        private void birdUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Bird.Top = Bird.Top - 50;
            }
        }

        private void Restart(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Application.Restart();
            }
        }
    }
}
