using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Player_BattleShip
{
    public static class UserInterface
    {
        public static void DisplayBoard(string[,] array, Player player)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write(array[i, j]);
                }
            }
            //Console.WriteLine(players[0].gameBoard.playerBoard +"\n" + players[0].gameBoard.hitBoard);
            //Console.WriteLine(players[1].gameBoard.playerBoard + "\n" + players[1].gameBoard.hitBoard);

        }
        public static void Intro()
        {
            Console.WriteLine("*                      _~                             *");
            Console.WriteLine("*                   _~ )_)_~                          *");
            Console.WriteLine("*                   )_))_))_)                         *");
            Console.WriteLine("*                   _!__!__!_                         *");
            Console.WriteLine("*                   \\______t/                         *");
            Console.WriteLine("*-----------------------------------------------------*");
            Console.WriteLine("* BATTLESHIP 3000: The Ultimate Battleship experience!*");
            Console.WriteLine("*-----------------------------------------------------*");
            Console.WriteLine("*Goal of the Game: Destroy all opposing player ships  *");
            Console.WriteLine("*-----------------------------------------------------*");
            Console.WriteLine("****Click any key to continue****");
            Console.ReadKey();
        }
        public static void Instructions()
        {
            Console.Clear();
            Console.WriteLine("*-----------------------------------------------------*");
            Console.WriteLine("*                 Instructions:                       *");
            Console.WriteLine("*-----------------------------------------------------*");
            Console.WriteLine("* 1) Players will each place their ships on gameboard *");
            Console.WriteLine("* 2) Players select coordinates to attack at start of *");
            Console.WriteLine("*    of each round                                    *");
            Console.WriteLine("* 3) Player to first destroy all opposing ships wins! *");
            Console.WriteLine("*-----------------------------------------------------*");
            Console.WriteLine("*            Ship types and hitpoints:                *");
            Console.WriteLine("* 1)Aircraft Carrier     |        5 hitpoins          *");
            Console.WriteLine("* 2)Battleship           |        4 hitpoins          *");
            Console.WriteLine("* 3)Submarine            |        3 hitpoins          *");
            Console.WriteLine("* 1)Destroyer            |        2 hitpoins          *");
            Console.WriteLine("*-----------------------------------------------------*");
            Console.WriteLine("Click any key to continue");
            Console.ReadLine();
        }
        public static void SelectName(List<Player> players,int integer)
        {
            Console.Clear();
            Console.WriteLine("*--------------------*");
            Console.WriteLine("*Name for {0}:  *", players[integer].name);
            Console.WriteLine("*--------------------*");
            string userName = Console.ReadLine();
            Console.WriteLine("Player name is now: {0}", userName);
            players[integer].name = userName;
            Console.WriteLine("Click any key to continue");
            Console.ReadKey();
        }



    }
}
