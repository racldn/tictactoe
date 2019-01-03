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
            throw new NotImplementedException();
        }
    }
   
}
