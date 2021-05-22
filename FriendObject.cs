using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncyDouncy
{
    class FriendObject : IObjectType
    {
        // <------Attributes Start-------->
        private PictureBox myObject;
        private int speed;
        private mainMovement movement = (mainMovement)new moveLeft();
        private static int totalFriends = 0;
        //<--------End------------>

        //<------------Constructor Start------>
        public FriendObject(PictureBox pictureBox, int speed, mainMovement movement)
        {
            this.speed = speed;
            this.movement = movement;
            this.myObject = pictureBox;
            totalFriends++;

        }
        // -----------Constructor overoloading for default left movement
        public FriendObject(PictureBox pictureBox, int speed)
        {
            this.speed = speed;
            this.myObject = pictureBox;
            totalFriends++;
        }

        //<----End-->

        public int getTotalFriends()
        {
            return totalFriends;
        }
        public PictureBox getGameObject()
        {
            return this.myObject;
        }

        public int getMovementSpeed()
        {
            return this.speed;
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
