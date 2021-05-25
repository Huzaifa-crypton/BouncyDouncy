using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SectionA2020CS02
{
    public class GameObject 
    {
        // <------Attributes Start-------->
        private PictureBox myObject;
        private int speed;
        private mainMovement movement = (mainMovement)new moveLeft();
        

        //<--------End------------>

        //<------------Constructor Start------>
        internal GameObject(PictureBox pictureBox, int speed, mainMovement movement)
        {
            this.speed = speed;
            this.movement = movement;
            this.myObject = pictureBox;
   

        }
        // -----------Constructor overoloading for default left movement
        internal GameObject(PictureBox pictureBox, int speed)
        {
            this.speed = speed;
            this.myObject = pictureBox;
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
