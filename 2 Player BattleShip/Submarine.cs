using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Player_BattleShip
{
    class Submarine : Ship
    {
        //member variable

        //constructor
        public Submarine()
        {
            this.type = "Submarine";
            this.isAlive = true;
            this.shipSegments = 3;
        }
        //member method

    }
}
