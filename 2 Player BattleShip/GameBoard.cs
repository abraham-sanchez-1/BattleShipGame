using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Player_BattleShip
{
    class GameBoard
    {
        //member variable (HAS A)
        public string[,] playerBoard;
        public string[,] hitBoard;


        //constructor  (SPAWNER)
        public GameBoard()
        {
            playerBoard = new string[20, 20];
            hitBoard = new string[20, 20];
            BoardCreation(playerBoard);
            BoardCreation(hitBoard);
        }

        //member method
        public void BoardCreation(string[,] array)
        {
            for (int i = 0; i < 20; i++)
            {

                for (int j = 0; j < 20; j++)
                {
                    array[i, j] = "( )";
                }
            }

        }

    }
}
