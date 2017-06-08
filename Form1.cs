using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace PingPong
{
    public partial class Form1 : Form
    {   int gameLevel = 1;
        int speedX = 10;
        int speedY = 10;
        int scoreCount = 0;
        
           
        public Form1()
        {
            int centerX = 320;
            int centerY = 400;
            Point centerPoint = new Point(centerX, centerY);
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            pictureBox1.Location = centerPoint;
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
         

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (scoreCount % 5 == 0 && scoreCount != 0)
            {
                gameLevel++;
                scoreCount = 0;
                speedX = speedX * gameLevel;
                speedY = speedY * gameLevel;
            }
            label1.Text = "Score:" + scoreCount.ToString();
            label2.Text = "Level:" + gameLevel;
            System.Console.WriteLine(pictureBox2.Location.X);
            if (pictureBox2.Location.Y <= 10 )
            {
                speedY = -speedY;
            }
          
            if (pictureBox2.Location.X <= 10 || 840 <=pictureBox2.Location.X)
            {
                speedX = -speedX;
            }
            if (390 <= pictureBox2.Location.Y  && (pictureBox2.Location.X <= pictureBox1.Location.X + 200 && pictureBox1.Location.X - 100 <= pictureBox2.Location.X))
            {
                speedY = -speedY;
                scoreCount++;
             

            }
            if (600 < pictureBox2.Location.Y)
            {
                this.Close();
            }
           
          
            pictureBox2.Location = new Point(pictureBox2.Location.X + speedX, pictureBox2.Location.Y - speedY);
            System.Console.WriteLine(pictureBox2.Location.Y);
            
            
        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space) { timer1.Enabled = !timer1.Enabled; }
            if(e.KeyCode == Keys.Escape) { this.Close(); }
            if(e.KeyCode == Keys.Left && timer1.Enabled == true) {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 20, pictureBox1.Location.Y);
                }
            if (e.KeyCode == Keys.Right && timer1.Enabled == true)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 20, pictureBox1.Location.Y);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
