using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncyDouncy
{
    public partial class MainGameInterface : Form
    {
        public MainGameInterface()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void MainGameInterface_Load(object sender, EventArgs e)
        {
            // Singleton Classes
            Game game = Game.getInstance();
            ObjectFactory factory = ObjectFactory.getInstance();
            //<-------------

            //<--------------Creating Objects witho movement----------->
            GameObject mainBall = factory.createObject(EnumObjectType.Friends, Ball, 15, new moveWithKeyBoard());
            GameObject spaceShip1 = factory.createObject(EnumObjectType.Enemy, enemySpaceship1, 11, new moveRight());
            GameObject spaceShip2 = factory.createObject(EnumObjectType.Enemy, enemySpaceship2, 9, new moveLeft());
            GameObject verticalPlatorm1 = factory.createObject(EnumObjectType.Platform, verticalPlatform1, 3, new moveUpDown());
            GameObject verticalPlatorm2 = factory.createObject(EnumObjectType.Platform, verticalPlatform2, -6, new moveUpDown());
            GameObject verticalPlatorm3 = factory.createObject(EnumObjectType.Platform, verticalPlatform3, -8, new moveUpDown());
            //<----------- Adding the created instance of GameObject in the array list of Game class
            game.addObject(mainBall);           // Adding the created instance of GameObject in the array list of Game class
            game.addObject(spaceShip1);           // Adding the created instance of GameObject in the array list of Game class
            game.addObject(spaceShip2);           // Adding the created instance of GameObject in the array list of Game class
            game.addObject(verticalPlatorm1);
            game.addObject(verticalPlatorm2);
            game.addObject(verticalPlatorm3);
            //<-----------End------------------->
            moveWithKeyBoard.direction = EnumDirection.Stop;
            totalEnemies.Text = "Enemies: " + Convert.ToString(factory.objectCount[(int)EnumObjectType.Enemy]);

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Game game = Game.getInstance();
            game.moveObjects();
        }

        private void MainGameInterface_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                moveWithKeyBoard.direction = EnumDirection.Up;          
            }
            else if (e.KeyCode == Keys.Down)
            {
                moveWithKeyBoard.direction = EnumDirection.Down;
            }
            else if (e.KeyCode == Keys.Right)
            {
                moveWithKeyBoard.direction = EnumDirection.Right;
            }
            else if (e.KeyCode == Keys.Left)
            {
                moveWithKeyBoard.direction = EnumDirection.Left;
            }
        }
        private void MainGameInterface_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                moveWithKeyBoard.direction = EnumDirection.Stop;
            }
            else if (e.KeyCode == Keys.Down)
            { 
                moveWithKeyBoard.direction = EnumDirection.Stop;
            }
            else if (e.KeyCode == Keys.Right)
            {
                moveWithKeyBoard.direction = EnumDirection.Stop;
            }
            else if (e.KeyCode == Keys.Left)
            {
                moveWithKeyBoard.direction = EnumDirection.Stop;
            }
        }

        private void totalEnemies_Click(object sender, EventArgs e)
        {

        }
    }
}
