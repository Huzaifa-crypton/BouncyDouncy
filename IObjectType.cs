using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncyDouncy
{
    interface IObjectType
    {
        mainMovement getMovemetType();
        int getMovementSpeed();
        void setMovementSpeed(int speed);
        PictureBox getGameObject();
    }
}
