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
        private IMovement movement = (IMovement)new moveLeft();
        

        //<--------End------------>

        //<------------Constructor Start------>
        internal GameObject(PictureBox pictureBox, int speed, IMovement movement)
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
 

        public IMovement getMovemetType()
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
