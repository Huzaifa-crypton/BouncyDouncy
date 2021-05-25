using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SectionA2020CS02 
{ 
    public class moveWithKeyBoard : mainMovement
    {
        public static EnumDirection direction;


        public void moveObject(GameObject movingObject)
        {
            if (direction == EnumDirection.Up)
            {
                movingObject.getGameObject().Top = movingObject.getGameObject().Top - movingObject.getMovementSpeed();
            }
            else if (direction == EnumDirection.Down)
            {
                movingObject.getGameObject().Top = movingObject.getGameObject().Top + movingObject.getMovementSpeed();
            }
            else if (direction == EnumDirection.Left)
            {
                movingObject.getGameObject().Left = movingObject.getGameObject().Left - movingObject.getMovementSpeed();
            }
            else if (direction == EnumDirection.Right)
            {
                movingObject.getGameObject().Left = movingObject.getGameObject().Left + movingObject.getMovementSpeed();
            }
            else
            {
                direction = EnumDirection.Stop;
            }

        }
    }
}
