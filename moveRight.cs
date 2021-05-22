using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncyDouncy
{
    class moveRight : mainMovement
    {
        public void moveObject(IObjectType movingObject)
        {
           
            movingObject.getGameObject().Left = movingObject.getGameObject().Left + movingObject.getMovementSpeed();
        }
    }
}
