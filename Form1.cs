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
            Game game = Game.getInstance();

            IObjectType mainBall = ObjectFactory.createObject(EnumObjectType.Friends, Ball, 10, new moveDown());
            IObjectType spaceShip1 = ObjectFactory.createObject(EnumObjectType.Enemy, enemySpaceship1, 11, new moveRight());
            IObjectType spaceShip2 = ObjectFactory.createObject(EnumObjectType.Enemy, enemySpaceship2, 9, new moveLeft());
            IObjectType verticalPlatorm1 = ObjectFactory.createObject(EnumObjectType.Platform, verticalPlatform1, 3, new moveUpDown());
            IObjectType verticalPlatorm2 = ObjectFactory.createObject(EnumObjectType.Platform, verticalPlatform2, -6, new moveUpDown());
            IObjectType verticalPlatorm3 = ObjectFactory.createObject(EnumObjectType.Platform, verticalPlatform3, -8, new moveUpDown());
            //<----------- Adding the created instance of IObject in the array list of Game class
            game.addObject(mainBall);           // Adding the created instance of GameObject in the array list of Game class
            game.addObject(spaceShip1);           // Adding the created instance of GameObject in the array list of Game class
            game.addObject(spaceShip2);           // Adding the created instance of GameObject in the array list of Game class
            game.addObject(verticalPlatorm1);
            game.addObject(verticalPlatorm2);
            game.addObject(verticalPlatorm3);
            //<-----------End------------------->
            totalEnemies.Text = "Enemies:" + EnemyObject.totalEnemies.ToString();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Game game = Game.getInstance();
            game.moveObjects();
        }
    }
}
