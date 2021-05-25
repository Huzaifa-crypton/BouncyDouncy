using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SectionA2020CS02
{
    public class moveRight : mainMovement
    {
        public void moveObject(GameObject movingObject)
        {

            movingObject.getGameObject().Left = movingObject.getGameObject().Left + movingObject.getMovementSpeed();
        }
    }
}
