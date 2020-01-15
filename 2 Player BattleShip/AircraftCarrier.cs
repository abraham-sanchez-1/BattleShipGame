using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Player_BattleShip
{
    class AircraftCarrier : Ship
    {
        //member variable

        //constructor
        public AircraftCarrier()
        {
            this.type = "Aircraft Carrier";
            this.isAlive = true;
            this.shipSegments = 5;
        }
        //member method
    }
}
