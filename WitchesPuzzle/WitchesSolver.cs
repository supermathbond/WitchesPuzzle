using System.Collections.Generic;
using System.Linq;

namespace WitchesPuzzle
{
    public class WitchesSolver
    {
        public const int BOARD_WIDTH = 3;
        public const int BOARD_HEIGHT = 3;

        private int _possibleWinBoardsCount = 0;

        public void Solve(WitchCard[] cards)
        {
            var list = cards.ToList();
            Board board = new Board(BOARD_WIDTH, BOARD_HEIGHT);

            innerSolver(list, board);
        }

        private void print(Board board)
        {
            _possibleWinBoardsCount++;
            // You are free to add your way for representing the completed board.
        }

        private void innerSolver(List<WitchCard> leftCards, Board board)
        {
            if(board.IsBoardCompleted())
            {
                print(board);
                return;
            }

            for (int i = 0; i < leftCards.Count; i++)
            {
                WitchCard chosenCard = leftCards[i];
                leftCards.RemoveAt(i);

                for (int j = 0; j < WitchCard.MAX_ROTATIONS; j++)
                {
                    if (board.TryAddNextCard(chosenCard))
                    {
                        innerSolver(leftCards, board);
                        board.RemoveLastCardFromBoard();
                    }

                    chosenCard.RotateCardClockwise();
                }

                leftCards.Insert(0, chosenCard);
            }
        }

    }
}
