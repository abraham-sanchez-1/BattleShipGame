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
            Intro();
            Instructions();
            players = new List<Player>() { new Player("Player 1"), new Player("Player 2") };
            for (int i = 0; i < 2; i++)
            {
                SelectName(i);
            }
            
        }

        //member method
        public void SelectName(int integer)
        {
            Console.WriteLine("Name for {0}:", players[integer].name);
            string userName = Console.ReadLine();
            Console.WriteLine("Player name is now: {0}", userName);
            players[integer].name = userName;
            Console.WriteLine("Click any key to continue");
            Console.ReadLine();
        }
        public void playGame()
        {
            PlayerSelection(0);
            PlayerSelection(1);
            
        }
        public void Intro()
        {
            Console.WriteLine("BATTLESHIP 3000: The Ultimate Battleship experience!\nGoal of the Game: Destroy all opposing player ships");
            Console.WriteLine("Click any key to continue");
            Console.ReadLine();
        }
        public void Instructions()
        {
            Console.WriteLine("Instructions:\n1) Players will each place ship on gameboard displayed by selecting ship and attaching coordinate\n2) Players select coordinate to attack at the start of each round\n3) Player to first destroy all opposing ships wins!\n");
            Console.WriteLine("Ship types and hitpoints:\n 1)Aircraft Carrier, |  5 hitpoins\n 2)Battleship,       |  4 hitpoints\n 3)Submarine,        |  3 hitpoints\n 2)Destroyer,        |  2 hitpoints\n");
            Console.WriteLine("Click any key to continue");
            Console.ReadLine();
        }
        public void PlayerSelection(int playerIndex)
        {
            Console.WriteLine("{0}'s board", players[playerIndex].name);
            DisplayBoard(players[playerIndex].gameBoard.playerBoard);
            Console.WriteLine("\nEnemy board");
            DisplayBoard(players[playerIndex].gameBoard.hitBoard);
        }
        public void DisplayBoard(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0) ; i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write(array[i,j]);
                }
                Console.WriteLine();
            }
            //Console.WriteLine(players[0].gameBoard.playerBoard +"\n" + players[0].gameBoard.hitBoard);
            //Console.WriteLine(players[1].gameBoard.playerBoard + "\n" + players[1].gameBoard.hitBoard);

        }

    }
}
