using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SectionA2020CS02
{
    public class MoveDown : IMovement
        {

        public void moveObject(GameObject movingObject )
        {
            movingObject.getGameObject().Top = movingObject.getGameObject().Top + movingObject.getMovementSpeed();
        }

    }
}
