using System;
using System.Collections.Generic;
using System.Linq;

namespace Connect4.Core
{
    public class AI
    {
        public enum Algorith
        {
            Random,
            MinMax,
            AlphaBeta
        }

        private readonly Algorith _algo;
        private readonly int _alpha = -Int32.MaxValue;
        private readonly int _beta = Int32.MaxValue;
        private readonly int _depth;
        private List<Tuple<int, int>> _moves;

        public AI(Game.Difficulty diff, Algorith algo)
        {
            _algo = algo;
            switch (algo)
            {
                case Algorith.AlphaBeta:_depth = (int) diff * 4;
                    break;
                case Algorith.MinMax: _depth = (int) diff * 2;
                    break;
                default: _depth = 0;
                    break;
            }
        }

        public AI() : this(Game.Difficulty.Medium, Algorith.MinMax) { }

        public int FindMove(Board board)
        {
            _moves = new List<Tuple<int, int>>();
            for (int i = 0; i < board.Columns; i++)
            {
                int score;
                if (!board.DropCoin(Game.Player.Computer, i)) continue;
                switch (_algo)
                {
                    case Algorith.AlphaBeta:
                        score = AlphaBeta(board, _alpha, _beta, _depth, false);
                        break;
                    case Algorith.MinMax:
                        score = MinMax(board, _depth, false);
                        break;
                    default:
                        score = 0;
                        break;
                }
                _moves.Add(Tuple.Create(i, score));
                board.RemoveCoin(i);
            }

            var random = new Random();
            var maxMoveScore = _moves.Max(t => t.Item2);
            var bestMoves = _moves.Where(t => t.Item2 == maxMoveScore).ToList();
            return bestMoves[random.Next(0, bestMoves.Count)].Item1;
        }

        private int MinMax(Board board, int depth, bool player)
        {
            if (GameTerminated(depth, board, player, out var score))
                return score;

            score = player ? -1 : 1;
            for (int i = 0; i < board.Columns; i++)
            {
                if (!board.DropCoin(player ? Game.Player.Computer : Game.Player.Human, i)) continue;
                var minMax = MinMax(board, depth - 1, !player);
                score = player ? Math.Max(score, minMax) : Math.Min(score, minMax);
                board.RemoveCoin(i);
            }

            return score;
        }

        private int AlphaBeta(Board board, int alpha, int beta, int depth, bool player)
        {
            if (GameTerminated(depth, board, player, out var score))
                return score;
            score = beta;

            for (int i = 0; i < board.Columns; i++)
            {
                if (!board.DropCoin(player ? Game.Player.Computer : Game.Player.Human, i)) continue;
                var value = -AlphaBeta(board, -score, -alpha, depth-1, !player);
                board.RemoveCoin(i);
                if (value < score) score = value;
                if (score <= alpha) return score;
            }
            return score;
        }

        private bool GameTerminated(int depth, Board board, bool player, out int score)
        {
            score = 0;
            if (board.FullBoard) return true;
            var winner = board.Winner;
            switch (winner)
            {
                case Game.Player.Human:
                    score = player ? depth : -depth;
                    if (_algo == Algorith.MinMax) score = -depth;
                    return true;
                case Game.Player.Computer:
                    score = player ? -depth : depth;
                    if (_algo == Algorith.MinMax) score = depth;
                    return true;
            }
            return depth <= 0;
        }
    }
}
