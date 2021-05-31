using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SectionA2020CS02
{
    public class ObjectFactory
    {
        static ObjectFactory object_factory;
        public int[] objectCount = new int[10];
        private ObjectFactory() { }
        public static ObjectFactory getInstance()
        {
            if (object_factory == null)
            {
                object_factory = new ObjectFactory();
            }

            return object_factory;
        }

        public GameObject createObject(EnumObjectType objectType , PictureBox pictureBox, int speed, IMovement movement)
        {
            GameObject gameObject = new GameObject(pictureBox ,speed, movement);
            objectCount[(int)objectType]++;                             // Increasing the number of objects created for a type
            return gameObject;
        }
    }
}
