using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    internal class Mage : Enemy
    {
        private int x;
        private int y;
        public override bool CheckRange(Character target)
        {
            if ((Math.Abs(this.x - Enemy.x) <= 1) ||
                   (Math.Abs(this.y - Enemy.y) <= 1)) // 2.3???
                return true;
            
        }
    }
}
