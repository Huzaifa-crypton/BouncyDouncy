using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace BouncyDouncy
{
    class Game
    {
        
        public static Game game;
        public ArrayList allObjects = new ArrayList(); 
        private Game(){}
        public static Game getInstance()
        {
            if (game == null)
            {
                game = new Game();
            }
            return game;
        }
      

        public void addObject(GameObjects gameObject)
        {
            allObjects.Add(gameObject);
        }

        public void moveObjects()
        {
            foreach (GameObjects go in allObjects)
            {
                go.getMovemetType().moveObject(go);

            }

            //for (int i = 0; i < allObjects.Count; i++)
            //{
            //    GameObjects gameObject = (GameObjects)allObjects[i];   // Type casting single GameObject instance
            //    PictureBox myGameObject;            //  Declaring a picture box variable to get the PB attribute             
            //    ////if (gameObject.getDirection() == directionEnum.Up)
            //    ////{
            //    ////    myGameObject = gameObject.getGameObject();
            //    ////    myGameObject.Top = myGameObject.Top - gameObject.getMovementSpeed();
            //    ////}
            //    ////else if (gameObject.getDirection() == directionEnum.Down) 
            //    ////{
            //    ////    myGameObject = gameObject.getGameObject();
            //    ////    myGameObject.Top = myGameObject.Top + gameObject.getMovementSpeed();
            //    ////}
            //    ////else if (gameObject.getDirection() == directionEnum.Right) 
            //    ////{
            //    ////    myGameObject = gameObject.getGameObject();
            //    ////    myGameObject.Left = myGameObject.Left + gameObject.getMovementSpeed();
            //    ////}
            //    ////else if (gameObject.getDirection() == directionEnum.Left) 
            //    ////{
            //    ////    myGameObject = gameObject.getGameObject();
            //    ////    myGameObject.Left = myGameObject.Left - gameObject.getMovementSpeed();
            //    ////}
            //}

            
        }
    }
}
