namespace WitchesPuzzle
{
    public class Board
    {
        private int _currentX = 0;
        private int _currentY = 0;

        public WitchCard[,] board;

        public Board(int width, int height)
        {
            board = new WitchCard[width, height];
        }

        public void RemoveLastCardFromBoard()
        {
            _currentX--;
            if (_currentX < 0)
            {
                _currentX = board.GetLength(0) - 1;
                _currentY--;
            }
            board[_currentX, _currentY] = null;
        }

        public bool IsBoardCompleted()
        {
            return board[board.GetLength(0) - 1, board.GetLength(1) - 1] != null;
        }

        public bool TryAddNextCard(WitchCard witchCard)
        {
            if (doesCardFitOnBoard(witchCard, _currentX, _currentY))
            {
                board[_currentX, _currentY] = witchCard;
                _currentX = (_currentX + 1) % board.GetLength(0);
                _currentY = (_currentX == 0) ? _currentY + 1 : _currentY;
                return true;
            }

            return false;
        }

        private bool doesCardFitOnBoard(WitchCard witchCard, int x, int y)
        {
            bool res = true;

            if (x - 1 >= 0)
            {
                res &= witchCard.MatchCard(board[x - 1, y], Direction.Left);
            }
            if (x + 1 < board.GetLength(0))
            {
                res &= witchCard.MatchCard(board[x + 1, y], Direction.Right);
            }
            if (y - 1 >= 0)
            {
                res &= witchCard.MatchCard(board[x, y - 1], Direction.Up);
            }
            if (y + 1 < board.GetLength(1))
            {
                res &= witchCard.MatchCard(board[x, y + 1], Direction.Down);
            }

            return res;
        }
    }
}
