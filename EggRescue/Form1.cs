using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggRescue
{
	public partial class Form1 : Form
	{
		bool goLeft, goRight;

		int speed = 10; // tốc độ rơi
		int score = 0; // điểm
		int missed = 0; // số lần trượt

		Random randX = new Random(); 
		Random randY = new Random();

		PictureBox splash = new PictureBox();
		public Form1()
		{
			InitializeComponent();
			RestartGame();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void RestartGame()
		{

			foreach (Control x in this.Controls)
			{
				if (x is PictureBox && (string)x.Tag == "eggs")
				{
					x.Top = randY.Next(80, 300) * -1;
					x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
				}
			}

			player.Left = this.ClientSize.Width / 2;
			player.Image = Properties.Resources.chicken_normal;

			score = 0;
			missed = 0;
			speed = 8;

			goLeft = false;
			goRight = false;

			GameTimer.Start();
		}

		private void MainGameTimerEvent(object sender, EventArgs e)
		{

			txtScore.Text = "Saved: " + score;
			txtMiss.Text = "Missed: " + missed;

			if (goLeft == true && player.Left > 0)
			{
				player.Left -= 12;
				player.Image = Properties.Resources.chicken_normal2;
			}
			if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
			{
				player.Left += 12;
				player.Image = Properties.Resources.chicken_normal;
			}

			foreach (Control x in this.Controls)
			{

				if (x is PictureBox && (string)x.Tag == "eggs")
				{

					x.Top += speed;

					if (x.Top + x.Height > this.ClientSize.Height)
					{

						splash.Image = Properties.Resources.splash;
						splash.Location = x.Location;
						splash.Height = 60;
						splash.Width = 60;
						splash.BackColor = Color.Transparent;

						this.Controls.Add(splash);

						x.Top = randY.Next(80, 300) * -1;
						x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
						missed += 1;
						player.Image = Properties.Resources.chicken_hurt;

					}


					if (player.Bounds.IntersectsWith(x.Bounds))
					{
						x.Top = randY.Next(80, 300) * -1;
						x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
						score += 1;
					}
				}
			}

			if (score > 15)
			{
				speed = 12;
			}
			if (score > 30)
			{
				speed = 14;
			}

			if (score > 45)
			{
				speed = 16;
			}
			if (score > 60)
			{
				speed = 18;
			}
			if (score > 75)
			{
				speed = 20;
			}
			if (score > 90)
			{
				speed = 22;
			}

			if (missed > 10)
			{
				GameTimer.Stop();
				MessageBox.Show("GAME OVER!" +  Environment.NewLine + "CLICK OK TO RESTART ");
				RestartGame();
			}
		}

		private void KeyIsDown(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.Left)
			{
				goLeft = true;
			}
			if (e.KeyCode == Keys.Right)
			{
				goRight = true;
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void txtMiss_Click(object sender, EventArgs e)
		{

		}

		private void KeyIsUp(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.Left)
			{
				goLeft = false;
			}
			if (e.KeyCode == Keys.Right)
			{
				goRight = false;
			}
		}
	}
}
