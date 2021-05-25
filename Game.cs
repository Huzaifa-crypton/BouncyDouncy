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
      

        public void addObject(GameObject gameObject)
        {
            allObjects.Add(gameObject);
        }

        public void moveObjects()
        {
            foreach (GameObject go in allObjects)
            {
                go.getMovemetType().moveObject(go);

            }
        }
    }
}
