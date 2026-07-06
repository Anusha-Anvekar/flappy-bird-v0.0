using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 4;
        int gravity = 10;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity; //add or subtract distance between top edge of container and form
            pipeTop.Left -= pipeSpeed;
            pipeBottom.Left -= pipeSpeed;
            scoreText.Text = "Score : " + score.ToString();

            //once the pipe move out of the screen(in the left), the pipes are repositioned at given pixels
            //if the pipe is passed successfully, score is increased
            //if score reaches multiple of 5, increase speed            
            if (pipeTop.Right < 0 || pipeBottom.Right < 0)
            {
                pipeTop.Left = pipeTop.Right < 0 ? 700 : pipeTop.Left;
                pipeBottom.Left = pipeBottom.Right < 0 ? 650 : pipeBottom.Left;

                score++;

                if (score % 5 == 0)
                {
                    pipeSpeed += 2;
                }
            }
            if (flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Top < 0 || flappyBird.Left < 0 || flappyBird.Right > this.Width)
            {
                endGame();
            }
            
        }

        //When space bar is not pressed, bird moves down
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10; //add gravity                
            }
            if (e.KeyCode == Keys.Left)
            {
                flappyBird.Left-= 10;
            }
            if (e.KeyCode == Keys.Right)
            {                
                flappyBird.Left+=10;                
            }
        }

        //When space bar is pressed, bird moves up
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Space) 
            {
                gravity = -10; //subtract gravity 
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            gameOverText.Text = "Game Over!!!\n    Score : " + score;
        }
    }
}
