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
        class moveDown : mainMovement
        {

        public void moveObject(IObjectType movingObject )
        {
            movingObject.getGameObject().Top = movingObject.getGameObject().Top + movingObject.getMovementSpeed();
        }

    }
}
