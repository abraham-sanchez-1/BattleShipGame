using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Player_BattleShip
{
    class Game
    {
        //member variable
        public List<Player> players;

        //constructor
        public Game()
        {
            intro();
            instructions();
            players = new List<Player>() { new Player(SelectName()), new Player(SelectName()) };

        }

        //member method
        public string SelectName()
        {
            Console.WriteLine("Name for player 1:");
            string userName = Console.ReadLine();
            return userName;
        }
        public void playGame()
        {

        }
        public void intro()
        {

        }
        public void instructions()
        {

        }

    }
}
