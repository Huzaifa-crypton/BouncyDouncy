using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncyDouncy
{
    class ObjectFactory
    {
        public static IObjectType createObject(EnumObjectType objectType , PictureBox pictureBox, int speed, mainMovement movement)
        {
            IObjectType myObject = null;

            if (objectType == EnumObjectType.Enemy)
            {
                myObject = new EnemyObject(pictureBox, speed, movement);
            }
            else if (objectType == EnumObjectType.Friends)
            {
                myObject = new FriendObject(pictureBox, speed, movement);
            }
            else if (objectType == EnumObjectType.Platform)
            {
                myObject = new PlatformObjects(pictureBox, speed, movement);
            }
            return myObject;
        }
    }
}
