
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
            this.staticPlatform2 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.verticalPlatform1 = new System.Windows.Forms.PictureBox();
            this.staticPlatform1 = new System.Windows.Forms.PictureBox();
            this.verticalPlatform2 = new System.Windows.Forms.PictureBox();
            this.verticalPlatform3 = new System.Windows.Forms.PictureBox();
            this.staticPlatform3 = new System.Windows.Forms.PictureBox();
            this.totalEnemies = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemySpaceship1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemySpaceship2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPlatform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticPlatform3)).BeginInit();
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
            // staticPlatform2
            // 
            this.staticPlatform2.BackColor = System.Drawing.Color.Transparent;
            this.staticPlatform2.BackgroundImage = global::BouncyDouncy.Properties.Resources.platform_removebg_preview;
            this.staticPlatform2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.staticPlatform2.Location = new System.Drawing.Point(343, 248);
            this.staticPlatform2.Name = "staticPlatform2";
            this.staticPlatform2.Size = new System.Drawing.Size(133, 22);
            this.staticPlatform2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staticPlatform2.TabIndex = 81;
            this.staticPlatform2.TabStop = false;
            this.staticPlatform2.Tag = "platform";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // verticalPlatform1
            // 
            this.verticalPlatform1.BackColor = System.Drawing.Color.Transparent;
            this.verticalPlatform1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verticalPlatform1.BackgroundImage")));
            this.verticalPlatform1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verticalPlatform1.Location = new System.Drawing.Point(158, 337);
            this.verticalPlatform1.Name = "verticalPlatform1";
            this.verticalPlatform1.Size = new System.Drawing.Size(73, 18);
            this.verticalPlatform1.TabIndex = 82;
            this.verticalPlatform1.TabStop = false;
            this.verticalPlatform1.Tag = "platform";
            // 
            // staticPlatform1
            // 
            this.staticPlatform1.BackColor = System.Drawing.Color.Transparent;
            this.staticPlatform1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("staticPlatform1.BackgroundImage")));
            this.staticPlatform1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.staticPlatform1.Location = new System.Drawing.Point(-1, 177);
            this.staticPlatform1.Name = "staticPlatform1";
            this.staticPlatform1.Size = new System.Drawing.Size(85, 22);
            this.staticPlatform1.TabIndex = 83;
            this.staticPlatform1.TabStop = false;
            this.staticPlatform1.Tag = "platform";
            // 
            // verticalPlatform2
            // 
            this.verticalPlatform2.BackColor = System.Drawing.Color.Transparent;
            this.verticalPlatform2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verticalPlatform2.BackgroundImage")));
            this.verticalPlatform2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verticalPlatform2.Location = new System.Drawing.Point(509, 309);
            this.verticalPlatform2.Name = "verticalPlatform2";
            this.verticalPlatform2.Size = new System.Drawing.Size(63, 21);
            this.verticalPlatform2.TabIndex = 84;
            this.verticalPlatform2.TabStop = false;
            this.verticalPlatform2.Tag = "platform";
            // 
            // verticalPlatform3
            // 
            this.verticalPlatform3.BackColor = System.Drawing.Color.Transparent;
            this.verticalPlatform3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verticalPlatform3.BackgroundImage")));
            this.verticalPlatform3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verticalPlatform3.Location = new System.Drawing.Point(636, 309);
            this.verticalPlatform3.Name = "verticalPlatform3";
            this.verticalPlatform3.Size = new System.Drawing.Size(39, 21);
            this.verticalPlatform3.TabIndex = 85;
            this.verticalPlatform3.TabStop = false;
            this.verticalPlatform3.Tag = "platform";
            // 
            // staticPlatform3
            // 
            this.staticPlatform3.BackColor = System.Drawing.Color.Transparent;
            this.staticPlatform3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("staticPlatform3.BackgroundImage")));
            this.staticPlatform3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.staticPlatform3.Location = new System.Drawing.Point(718, 309);
            this.staticPlatform3.Name = "staticPlatform3";
            this.staticPlatform3.Size = new System.Drawing.Size(73, 21);
            this.staticPlatform3.TabIndex = 86;
            this.staticPlatform3.TabStop = false;
            this.staticPlatform3.Tag = "platform";
            // 
            // totalEnemies
            // 
            this.totalEnemies.AutoSize = true;
            this.totalEnemies.BackColor = System.Drawing.Color.Transparent;
            this.totalEnemies.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEnemies.ForeColor = System.Drawing.Color.Azure;
            this.totalEnemies.Location = new System.Drawing.Point(13, 24);
            this.totalEnemies.Name = "totalEnemies";
            this.totalEnemies.Size = new System.Drawing.Size(93, 19);
            this.totalEnemies.TabIndex = 87;
            this.totalEnemies.Text = "Enemies : 0";
            // 
            // MainGameInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BouncyDouncy.Properties.Resources.spaceBG;
            this.ClientSize = new System.Drawing.Size(793, 445);
            this.Controls.Add(this.totalEnemies);
            this.Controls.Add(this.staticPlatform3);
            this.Controls.Add(this.verticalPlatform3);
            this.Controls.Add(this.verticalPlatform2);
            this.Controls.Add(this.staticPlatform1);
            this.Controls.Add(this.verticalPlatform1);
            this.Controls.Add(this.staticPlatform2);
            this.Controls.Add(this.enemySpaceship2);
            this.Controls.Add(this.enemySpaceship1);
            this.Controls.Add(this.Ball);
            this.Name = "MainGameInterface";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Tag = "mainGameInterface";
            this.Text = "Bouncy Douncy";
            this.Load += new System.EventHandler(this.MainGameInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemySpaceship1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemySpaceship2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPlatform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticPlatform3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox enemySpaceship1;
        private System.Windows.Forms.PictureBox enemySpaceship2;
        private System.Windows.Forms.PictureBox staticPlatform2;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox verticalPlatform1;
        private System.Windows.Forms.PictureBox staticPlatform1;
        private System.Windows.Forms.PictureBox verticalPlatform2;
        private System.Windows.Forms.PictureBox verticalPlatform3;
        private System.Windows.Forms.PictureBox staticPlatform3;
        private System.Windows.Forms.Label totalEnemies;
    }
}

