using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionA2020CS02
{
    public class ObjectPool
    {
        private static ObjectPool poolObject;
        private ObjectPool() { }

        private static List<MovementObjectPool> availableMovements = new List<MovementObjectPool>();
        private static List<MovementObjectPool> occupiedMovements = new List<MovementObjectPool>();
        public static int keybord = 0;
        public static int left = 0;
        public static int down = 0;
        public static int patrol = 0;
        public static int up = 0;
        public static int right = 0;
        public static int available = availableMovements.Count;
        public static int occupied = occupiedMovements.Count;
        public static ObjectPool getInstance()
        {
            if (poolObject == null)
            {
                poolObject = new ObjectPool();
            }
            return poolObject;
        }

        public IMovement getResource(EnumMovementType movement)
        {
            int i = 0; 
            foreach (MovementObjectPool movementType in availableMovements)
            {
                if (movement == movementType.GetEnumMovement() && movement == EnumMovementType.KeyboardMovement)
                {
                    occupiedMovements.Add(movementType);
                    availableMovements.Remove(availableMovements[i]);
                    return movementType.GetIMovement();
                }
                else if (movement == movementType.GetEnumMovement())
                {
                    return movementType.GetIMovement();
                }
                i++;
            }
            return createMovement(movement);

        }
        private IMovement createMovement(EnumMovementType movement)
        {
            MovementObjectPool newMovement = null;
            if (movement == EnumMovementType.KeyboardMovement)
            {
                newMovement = new MovementObjectPool(movement , new MoveWithKeyBoard() );
            }
            else if (movement == EnumMovementType.Patrol)
            {
                newMovement = new MovementObjectPool(movement, new MoveUpDown());
            }
            else if (movement == EnumMovementType.RightMovement)
            {
                newMovement = new MovementObjectPool(movement, new MoveRight());
            }
            else if (movement == EnumMovementType.LeftMovement)
            {
                newMovement = new MovementObjectPool(movement, new moveLeft());
            }
            else if (movement == EnumMovementType.DownwardMovement)
            {
                newMovement = new MovementObjectPool(movement, new MoveDown());
            }
            occupiedMovements.Add(newMovement);
            return newMovement.GetIMovement();
        }
        public void countMovmentObjects()
        {
            foreach (MovementObjectPool movement in availableMovements)
            {
                if (movement.GetEnumMovement() == EnumMovementType.KeyboardMovement)
                {
                    keybord++;
                }
                else if (movement.GetEnumMovement() == EnumMovementType.RightMovement)
                {
                    right++;
                }
                else if (movement.GetEnumMovement() == EnumMovementType.LeftMovement)
                {
                    left++;
                }
                else if (movement.GetEnumMovement() == EnumMovementType.UpwardMovement)
                {
                    up++;
                }
                else if (movement.GetEnumMovement() == EnumMovementType.Patrol)
                {
                    patrol++;
                }
                if (movement.GetEnumMovement() == EnumMovementType.DownwardMovement)
                {
                    down++;
                }

            }
            foreach (MovementObjectPool movement in occupiedMovements)
            {
                if (movement.GetEnumMovement() == EnumMovementType.KeyboardMovement)
                {
                    keybord++;
                }
                else if (movement.GetEnumMovement() == EnumMovementType.RightMovement)
                {
                    right++;
                }
                else if (movement.GetEnumMovement() == EnumMovementType.LeftMovement)
                {
                    left++;
                }
                else if (movement.GetEnumMovement() == EnumMovementType.UpwardMovement)
                {
                    up++;
                }
                else if (movement.GetEnumMovement() == EnumMovementType.Patrol)
                {
                    patrol++;
                }
                if (movement.GetEnumMovement() == EnumMovementType.DownwardMovement)
                {
                    down++;
                }

            }
            available = availableMovements.Count;
            occupied = occupiedMovements.Count;
        }
    }
}
