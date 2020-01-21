using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Player_BattleShip
{
    public class Destroyer : Ship
    {
        //member variable

        //constructor
        public Destroyer()
        {
            this.type = "Destroyer";
            this.isAlive = true;
            this.shipSegments = 2;
        }
        //member method

    }
}
