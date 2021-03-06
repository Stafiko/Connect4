﻿using System;
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
            _depth = _algo == Algorith.AlphaBeta
                ? (int) diff * 3
                : (int) diff * 2;
        }

        public AI() : this(Game.Difficulty.Medium, Algorith.MinMax) { }

        public int FindMove(Board board)
        {
            _moves = new List<Tuple<int, int>>();
            for (int i = 0; i < board.Columns; i++)
            {
                if (!board.MakeMove(i, true, Game.Player.Computer)) continue;
                var score = _algo == Algorith.AlphaBeta
                    ? AlphaBeta(board, _alpha, _beta, _depth, false)
                    : _algo == Algorith.MinMax
                        ? MinMax(board, _depth, false)
                        : 0;
                _moves.Add(Tuple.Create(i, score));
                board.MakeMove(i);
            }

            var random = new Random();
            var bestMoves = _moves.Where(t => t.Item2 == _moves.Max(m => m.Item2)).ToList();
            return bestMoves[random.Next(0, bestMoves.Count)].Item1;
        }

        private int MinMax(Board board, int depth, bool player)
        {
            if (GameTerminated(depth, board, player, out var score))
                return score;

            score = player ? -1 : 1;
            for (int i = 0; i < board.Columns; i++)
            {
                if (!board.MakeMove(i, true, player ? Game.Player.Computer : Game.Player.Human)) continue;
                var minMax = MinMax(board, depth - 1, !player);
                score = player ? Math.Max(score, minMax) : Math.Min(score, minMax);
                board.MakeMove(i);
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
                if (!board.MakeMove(i, true, player ? Game.Player.Computer : Game.Player.Human)) continue;
                var value = -AlphaBeta(board, -score, -alpha, depth-1, !player);
                board.MakeMove(i);
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
            var isMinMax = _algo == Algorith.MinMax;
            switch (winner)
            {
                case Game.Player.Human:
                    score = player ? depth : -depth;
                    if (isMinMax) score = -depth;
                    return true;
                case Game.Player.Computer:
                    score = player ? -depth : depth;
                    if (isMinMax) score = depth;
                    return true;
            }
            return depth <= 0;
        }
    }
}
