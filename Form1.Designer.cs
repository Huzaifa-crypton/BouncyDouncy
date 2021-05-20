
namespace BouncyDouncy
{
    partial class MainGameInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameInterface));
            this.Ball = new System.Windows.Forms.PictureBox();
            this.enemySpaceship1 = new System.Windows.Forms.PictureBox();
            this.enemySpaceship2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemySpaceship1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemySpaceship2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ball.BackgroundImage")));
            this.Ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ball.Location = new System.Drawing.Point(391, 79);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(31, 26);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // enemySpaceship1
            // 
            this.enemySpaceship1.BackColor = System.Drawing.Color.Transparent;
            this.enemySpaceship1.BackgroundImage = global::BouncyDouncy.Properties.Resources.spaceShip___Copy;
            this.enemySpaceship1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemySpaceship1.Location = new System.Drawing.Point(12, 126);
            this.enemySpaceship1.Name = "enemySpaceship1";
            this.enemySpaceship1.Size = new System.Drawing.Size(40, 45);
            this.enemySpaceship1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemySpaceship1.TabIndex = 79;
            this.enemySpaceship1.TabStop = false;
            this.enemySpaceship1.Tag = "enemySpaceship";
            // 
            // enemySpaceship2
            // 
            this.enemySpaceship2.BackColor = System.Drawing.Color.Transparent;
            this.enemySpaceship2.BackgroundImage = global::BouncyDouncy.Properties.Resources.spaceShip;
            this.enemySpaceship2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemySpaceship2.Location = new System.Drawing.Point(751, 192);
            this.enemySpaceship2.Name = "enemySpaceship2";
            this.enemySpaceship2.Size = new System.Drawing.Size(40, 45);
            this.enemySpaceship2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemySpaceship2.TabIndex = 80;
            this.enemySpaceship2.TabStop = false;
            this.enemySpaceship2.Tag = "enemySpaceship";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BouncyDouncy.Properties.Resources.platform_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(343, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 25;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // MainGameInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BouncyDouncy.Properties.Resources.spaceBG;
            this.ClientSize = new System.Drawing.Size(793, 445);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enemySpaceship2);
            this.Controls.Add(this.enemySpaceship1);
            this.Controls.Add(this.Ball);
            this.Name = "MainGameInterface";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Bouncy Douncy";
            this.Load += new System.EventHandler(this.MainGameInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemySpaceship1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemySpaceship2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox enemySpaceship1;
        private System.Windows.Forms.PictureBox enemySpaceship2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer gameTimer;
    }
}

