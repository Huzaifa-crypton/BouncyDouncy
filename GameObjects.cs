using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BouncyDouncy
{
    class GameObjects
    {
        // <------Attributes Start-------->
        private PictureBox myObject;
        private int speed;
        private mainMovement movement = (mainMovement) new moveLeft(); 
       //<--------End------------>

        //<------------Constructor Start------>
        public GameObjects(PictureBox pictureBox, int speed, mainMovement movement)
        {
            this.speed = speed;
            this.movement = movement;
            this.myObject = pictureBox;

        }

        public GameObjects(PictureBox pictureBox, int speed)
        {
            this.speed = speed;
            this.myObject = pictureBox;

        }
        //<----End-->


        //Getter Function Starts
        public mainMovement getMovemetType()
        {
            return this.movement;
        }


        public int getMovementSpeed()
        {
           
            return this.speed;
        }
        public PictureBox getGameObject()
        {
            return this.myObject;
        }

        // <--------Getter Function End>
    }
}
