using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Player_BattleShip
{
    class Battleship : Ship
    {
        //member variable

        //constructor
        public Battleship()
        {
            this.type = "Battleship";
            this.isAlive = true;
            this.shipSegments = 4;
        }
        //member method

    }
}
