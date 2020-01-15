using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Player_BattleShip
{
    class Player
    {
        //member variable
        public string name;
        public int score;
        public List<Ship> ships;
        public GameBoard gameBoard;

        //constructor
        public Player(string name)
        {
            this.name = name;
            score = 0;
            ships = new List<Ship>() { new AircraftCarrier(), new Battleship(), new Submarine(), new Destroyer()};
            gameBoard = new GameBoard();
        }

        //member method
        public void AssignShipLocation()
        {

        }
        //can place ships
        //can attack
    }
}
