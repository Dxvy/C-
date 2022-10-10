using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPurple
{
    public partial class Form1 : Form
    {
        bool goleft;
 
        bool goright;
 
        int speed = 5;
 
        int score = 0;
 
        bool isPressed;
 
        int totalEnemies = 12;
 
        int playerSpeed = 6;
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if(goleft)
            {
                Player.Left -= playerSpeed;
            }
            else if(goright)
            {
                Player.Left += playerSpeed;
            }        }
        
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
 
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !isPressed)
            {
                isPressed = true;
 
                makeBullet();
            }
        }
 
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
 
                goleft = false;
            }
 
            if (e.KeyCode == Keys.Right)
            {
 
                goright = false;
            }
            if (isPressed)
            {
                isPressed = false;
            }
        }
        private void makeBullet()
        {
            PictureBox bullet = new PictureBox();
 
            bullet.Image = Image.FromFile("Img/laser.png");
 
            bullet.Size = new Size(5, 20);
 
            bullet.Tag = "bullet";
 
            bullet.Left = Player.Left + Player.Width / 2;
 
            bullet.Top = Player.Top - 20;
 
            this.Controls.Add(bullet);
 
            bullet.BringToFront();
 
        }
        private void gameOver()
        {
            timer1.Stop();
            label1.Text += " Game Over";
        }

        private void Player_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}