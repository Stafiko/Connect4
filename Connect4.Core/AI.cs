using System;
using System.Collections.Generic;
using System.Linq;

namespace Connect4.Core
{
    public class AI
    {
        private readonly int _depth;
        private List<Tuple<int, int>> _moves;

        public AI(Game.Difficulty diff)
        {
            _depth = (int) diff;
        }

        public AI() : this(Game.Difficulty.Medium) { }

        public int FindMove(Board board)
        {
            _moves = new List<Tuple<int, int>>();
            for (int i = 0; i < board.Columns; i++)
            {
                if (!board.DropCoin(Game.Player.Computer, i)) continue;
                _moves.Add(Tuple.Create(i, MinMax(_depth, board, false)));
                board.RemoveCoin(i);
            }

            var random = new Random();
            var maxMoveScore = _moves.Max(t => t.Item2);
            var bestMoves = _moves.Where(t => t.Item2 == maxMoveScore).ToList();
            return bestMoves[random.Next(0, bestMoves.Count)].Item1;
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
