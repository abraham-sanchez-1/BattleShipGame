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
                AssignShips(i);
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
        public void AssignShips(int integer)
        {
            for (int i = 0; i < players[integer].ships.Count; i++)
            {
                int firstCoordinate; int secondCoordinate; int orientation;
                DisplayBoard(players[integer].gameBoard.playerBoard);
                Console.WriteLine("{0} is selected\nPlease assign a row and column", players[integer].ships[i].type);
                firstCoordinate = RowCoordinateSelection();
                secondCoordinate = ColumnCoordinateSelection();
                orientation = OrientationSelection(integer,i);
                //function that uses firstCoordinate, secondCoordinate, orientation
            }
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
        public void ShipAssignHorizontal(Ship ship)
        {

        }
        public void ShipAssignVertical(Ship ship)
        {

        }
        public int RowCoordinateSelection()
        {
            int userSelection = 0;
            Console.Write("Select Row (1-20):");
            int.TryParse(Console.ReadLine(), out userSelection);
            if(userSelection ==0 || userSelection >20)
            {
                Console.WriteLine("Input was invalid, make sure you are typing a number between 1-20");
                RowCoordinateSelection();
            }
            return userSelection;
            
        }
        public int ColumnCoordinateSelection()
        {
            int userSelection = 0;
            Console.Write("Select Column (1-20):");
            int.TryParse(Console.ReadLine(), out userSelection);
            if (userSelection == 0 || userSelection > 20)
            {
                Console.WriteLine("Input was invalid, make sure you are typing a number between 1-20");
                ColumnCoordinateSelection();
            }
            return userSelection;
        }
        public int OrientationSelection(int playerIndex,int shipIndex)
        {
            int userSelection = 0;
            int shipNumber = shipIndex;
            int playerNumber = playerIndex;
            Console.WriteLine("Orientation of {0}", players[playerNumber].ships[shipNumber].type);
            Console.WriteLine("1) Horizontal\n2) Vertical");
            int.TryParse(Console.ReadLine(), out userSelection);
            switch (userSelection)
            {
                case 1:
                    userSelection = 1;
                    Console.WriteLine("{0} will be placed horizontally!",players[playerNumber].ships[shipNumber].type);
                    return userSelection;
                case 2:
                    userSelection = 2;
                    Console.WriteLine("{0} will be placed vertically!", players[playerNumber].ships[shipNumber].type);
                    return userSelection;

                default:
                    Console.WriteLine("The option you selected is not valid");
                    OrientationSelection(shipNumber,shipIndex);
                    return userSelection;
                    

            }
        }
    }
}
