﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionA2020CS02
{
    public class MoveUpDown : IMovement
    {
        public void moveObject(GameObject movingObject)
        {
            movingObject.getGameObject().Top = movingObject.getGameObject().Top + movingObject.getMovementSpeed();
            if (movingObject.getGameObject().Top < 0 || movingObject.getGameObject().Top + movingObject.getGameObject().Height > 440)
            {
                movingObject.setMovementSpeed(-movingObject.getMovementSpeed());
            }
        }
    }
}
