using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeServices
{
    public interface IGameWinnerService
    {
        char Validate(char[,] gameboard);
    }

    public class GameWinnerService : IGameWinnerService
    {
        public char Validate(char[,] gameboard)
        {
            var currentWinningSymbol = ' ';
            currentWinningSymbol = ChecksForThreeInARowHorizontalRow(gameboard);

            var rowOneChar = gameboard[0, 0];
            var rowTwoChar = gameboard[1, 0];
            var rowThreeChar = gameboard[2, 0];
            if (rowOneChar == rowTwoChar && rowTwoChar == rowThreeChar)
            {
                currentWinningSymbol =  rowOneChar;
            }
            return currentWinningSymbol;
        }

        private static char ChecksForThreeInARowHorizontalRow(char[,] gameboard)
        {
            var columnOneChar = gameboard[0, 0];
            var columnTwoChar = gameboard[0, 1];
            var columnThreeChar = gameboard[0, 2];
            if (columnOneChar == columnTwoChar && columnTwoChar == columnThreeChar)
            {
                return columnOneChar;
            }
            return ' ';
        }
    }
   
}
