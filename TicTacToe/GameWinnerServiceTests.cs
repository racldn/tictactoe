using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TicTacToeServices;

namespace TicTacToe

{
    [TestFixture]
    public class GameWinnerServiceTests
    {
        [Test]
        public void NeitherPlayerHasthreeInARow()
        {
            IGameWinnerService gameWinnerService;
            gameWinnerService = new GameWinnerService();
            const char expected = ' ';
            var gameboard = new char[3, 3]
            {
                {' ', ' ', ' '},
                {' ', ' ', ' '},
                {' ', ' ', ' '}
            };

            var actual = gameWinnerService.Validate(gameboard);
            Assert.AreEqual(expected, actual);
        } 
    }
}
