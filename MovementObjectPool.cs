using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionA2020CS02
{
    public class MovementObjectPool
    {
        private EnumMovementType enumMovementType;
        private IMovement imovement;

        public MovementObjectPool(EnumMovementType enumMovementType , IMovement imovement)
        {
            this.enumMovementType = enumMovementType;
            this.imovement = imovement;
        }

        public EnumMovementType GetEnumMovement()
        {
            return this.enumMovementType;
        }
        public IMovement GetIMovement()
        {
            return this.imovement;
        }
        public void setEnumMovement(EnumMovementType enumMovementType)
        {
            this.enumMovementType = enumMovementType;
        }
        public void setIMovement(IMovement imovement)
        {
            this.imovement = imovement;
        }
    }
}
