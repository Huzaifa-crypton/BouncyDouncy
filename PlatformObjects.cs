using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncyDouncy
{
    class PlatformObjects : IObjectType
    {
        // <------Attributes Start-------->
        private PictureBox myObject;
        private int speed;
        private mainMovement movement = (mainMovement)new moveLeft();
        private static int totalPlatforms = 0;

        //<--------End------------>

        //<------------Constructor Start------>
        public PlatformObjects(PictureBox pictureBox, int speed, mainMovement movement)
        {
            this.speed = speed;
            this.movement = movement;
            this.myObject = pictureBox;
            totalPlatforms++;

        }
        // -----------Constructor overoloading for default left movement
        public PlatformObjects(PictureBox pictureBox, int speed)
        {
            this.speed = speed;
            this.myObject = pictureBox;
            totalPlatforms++;
        }

        //<----End-->


        public PictureBox getGameObject()
        {
            return this.myObject;
        }

        public int getMovementSpeed()
        {
            return this.speed;
        }
        public int getTotalEnemies()
        {
            return totalPlatforms;
        }

        public mainMovement getMovemetType()
        {
            return this.movement;
        }

        public void setMovementSpeed(int speed)
        {
            this.speed = speed;
        }
        //<--------End------------>
    }
}
