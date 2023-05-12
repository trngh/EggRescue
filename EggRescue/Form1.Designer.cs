namespace EggRescue
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
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.player = new System.Windows.Forms.PictureBox();
			this.txtScore = new System.Windows.Forms.Label();
			this.txtMiss = new System.Windows.Forms.Label();
			this.GameTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::EggRescue.Properties.Resources.egg;
			this.pictureBox3.Location = new System.Drawing.Point(521, 120);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(57, 71);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Tag = "eggs";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::EggRescue.Properties.Resources.egg;
			this.pictureBox2.Location = new System.Drawing.Point(302, 120);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(57, 71);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Tag = "eggs";
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::EggRescue.Properties.Resources.egg;
			this.pictureBox1.Location = new System.Drawing.Point(72, 120);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(57, 71);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "eggs";
			// 
			// player
			// 
			this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.player.Image = global::EggRescue.Properties.Resources.chicken_normal;
			this.player.Location = new System.Drawing.Point(195, 680);
			this.player.Name = "player";
			this.player.Size = new System.Drawing.Size(103, 89);
			this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.player.TabIndex = 0;
			this.player.TabStop = false;
			// 
			// txtScore
			// 
			this.txtScore.AutoSize = true;
			this.txtScore.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtScore.Location = new System.Drawing.Point(28, 34);
			this.txtScore.Name = "txtScore";
			this.txtScore.Size = new System.Drawing.Size(90, 36);
			this.txtScore.TabIndex = 6;
			this.txtScore.Text = "Score: 0";
			// 
			// txtMiss
			// 
			this.txtMiss.AutoSize = true;
			this.txtMiss.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMiss.Location = new System.Drawing.Point(217, 34);
			this.txtMiss.Name = "txtMiss";
			this.txtMiss.Size = new System.Drawing.Size(81, 36);
			this.txtMiss.TabIndex = 7;
			this.txtMiss.Text = "Miss: 0";
			this.txtMiss.Click += new System.EventHandler(this.txtMiss_Click);
			// 
			// GameTimer
			// 
			this.GameTimer.Enabled = true;
			this.GameTimer.Interval = 30;
			this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(710, 769);
			this.Controls.Add(this.txtMiss);
			this.Controls.Add(this.txtScore);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.player);
			this.Name = "Form1";
			this.Text = "Egg Rescue";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox player;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label txtScore;
		private System.Windows.Forms.Label txtMiss;
		private System.Windows.Forms.Timer GameTimer;
	}
}

