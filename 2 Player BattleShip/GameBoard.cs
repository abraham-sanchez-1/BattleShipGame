using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Player_BattleShip
{
    public class GameBoard
    {
        //member variable (HAS A)
        public string[,] playerBoard;
        public string[,] hitBoard;
        List<string> alphabet;

        //constructor  (SPAWNER)
        public GameBoard()
        {
            playerBoard = new string[20, 20];
            hitBoard = new string[20, 20];
            alphabet = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            BoardCreation(playerBoard);
            BoardCreation(hitBoard);
        }

        //member method
        public void BoardCreation(string[,] array)
        {
            for (int i = 0; i < 11; i++)
            {

                for (int j = 0; j < 11; j++)
                {
                    array[i, j] = "( )";
                }
            }
            for (int i = 1; i < 11; i++)
            {
                array[0,i] = "(" + i + ")";
            }
            for (int i = 1; i < 11; i++)
            {
                array[i, 0] = "(" + alphabet[i - 1] + ")";
            }


        }

    }
}
