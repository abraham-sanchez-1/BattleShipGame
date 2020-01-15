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
            Console.WriteLine("BATTLESHIP 3000: The Ultimate Battleship experience!\nGoal of the Game: Destroy all opposing player ships");
            Console.WriteLine("Click any key to continue");
            Console.ReadLine();
        }
        public void instructions()
        {
            Console.WriteLine("Instructions:\n1) Players will each place ship on gameboard displayed by selecting ship and attaching coordinate\n2)Players select coordinate to attack at the start of each round\n3)Player to first destroy all opposing ships wins!\n");
            Console.WriteLine("Click any key to continue");
            Console.ReadLine();
        }

    }
}
