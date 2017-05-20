using System;

namespace Connect4.Core
{
    public class AI
    {
        private readonly int _depth;

        public AI(Game.Difficulty diff)
        {
            _depth = (int) diff;
        }

        public AI() : this(Game.Difficulty.Medium) { }
         
        public int FindMove(Board board)
        {
            var bestMove = MinMax(_depth, board, false);
            return bestMove;
        }

        private int MinMax(int depth, Board board, bool player)
        {
            var winner = board.Winner;
            if (depth <= 0 || board.FullBoard) return 0;
            switch (winner)
            {
                case Game.Player.Human: return -depth;
                case Game.Player.Computer: return depth;
            }

            var bestValue = player ? -1 : 1;
            for (int i = 0; i < board.Columns; i++)
            {
                if (!board.DropCoin(player ? Game.Player.Computer : Game.Player.Human, i)) continue;
                var minMax = MinMax(depth - 1, board, !player);
                bestValue = player ? Math.Max(bestValue, minMax) : Math.Min(bestValue, minMax);
                board.RemoveCoin(i);
            }

            return bestValue;
        }       
    }
}
