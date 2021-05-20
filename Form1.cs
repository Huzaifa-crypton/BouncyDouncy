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

        private void MainGameInterface_Load(object sender, EventArgs e)
        {
            Game game = Game.getInstance();

            GameObjects mainBall = new GameObjects(Ball, 10, new moveDown());
            GameObjects spaceShip1 = new GameObjects(enemySpaceship1, 11, new moveRight());
            GameObjects spaceShip2 = new GameObjects(enemySpaceship2, 9, new moveLeft());
            
            game.addObject(mainBall);           // Adding the created instance of GameObject in the array list of Game class
            game.addObject(spaceShip1);           // Adding the created instance of GameObject in the array list of Game class
            game.addObject(spaceShip2);           // Adding the created instance of GameObject in the array list of Game class

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Game game = Game.getInstance();
            game.moveObjects();
        }
    }
}
