using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Connect4.Core
{
    public static class Game
    {
        private static Player _player;
        private static AI _ai;
        private static Random _random;
        private static Board _board;
        public static Board Board => _board;
        private static bool _gameOver;
        public static bool GameOver => _gameOver;
        private static int _boardWidth, _boardHeight;

        public static void GameInitiaize(int width, int height, 
            bool versusAI, bool first, int difficulty = 1)
        {
            var diff = Difficulty.Medium;
            _ai = null;
            _gameOver = false;
            _player = Player.Human;
            _boardWidth = width;
            _boardHeight = height;
            _board = new Board(_boardWidth, _boardHeight);
            _random = new Random();
            switch (difficulty)
            {
                case 0: diff = Difficulty.Easy;
                    break;
                case 1: diff = Difficulty.Medium;
                    break;
                case 2: diff = Difficulty.Hard;
                    break;
            }
            if (!versusAI) return;
            _ai = new AI(diff);

            if (first) return;
            _player = Player.Computer;
            GameMove(0, out var temp);
        }

        public static bool GameMove(int move, out int?[,] field)
        {
            field = _board.Fields;

            if (_player == Player.Human || _ai == null)
            {
                if (!_board.DropCoin(_player, move)) return false;
                _player = ~_player;
            }

            if (_board.FullBoard)
            {
                _gameOver = true;
                GameIsOver();
                return false;
            }

            if (_ai != null)
            {
                var moves = new List<Tuple<int, int>>();
                for (int i = 0; i < _board.Columns; i++)
                {
                    if (!_board.DropCoin(_player, i))
                        continue;
                    moves.Add(Tuple.Create(i, _ai.FindMove(_board)));
                    _board.RemoveCoin(i);
                }

                var maxMoveScore = moves.Max(t => t.Item2);
                var bestMoves = moves.Where(t => t.Item2 == maxMoveScore).ToList();
                _board.DropCoin(_player, bestMoves[_random.Next(0, bestMoves.Count)].Item1);
                _player = ~_player;
            }

            _gameOver = _board.Winner == Player.Human || _board.Winner == Player.Computer || _board.FullBoard;
            if (_gameOver) GameIsOver();
            return true;
        }

        private static void GameIsOver()
        {
            if (_ai == null)
                if (_board.Winner != null)
                    MessageBox.Show(_board.Winner == Player.Human ? "Победа белых!" : "Победа черных!",
                        "Игра окончена", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Ничья!", "Игра окончен", MessageBoxButtons.OK);

            else if (_board.Winner != null)
                MessageBox.Show(_board.Winner == Player.Human ? "Человек победил!" : "Компьютер победил!",
                    "Игра окончена", MessageBoxButtons.OK);
            else
                MessageBox.Show("Ничья!", "Игра окончен", MessageBoxButtons.OK);
        }

        [Flags]
        public enum Player
        {
            Human = 0,
            Computer = -1
        }

        public enum Difficulty
        {
            Easy = 3,
            Medium = 5,
            Hard = 7
        }
    }
}

