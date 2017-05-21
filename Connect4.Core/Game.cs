﻿using System;
using System.Windows.Forms;

namespace Connect4.Core
{
    public static class Game
    {
        private static Player _player;
        private static AI _ai;
		
        private static Board _board;
        public static Board Board => _board;  
		private static int _boardWidth, _boardHeight;
		
        private static bool _gameOver;
        public static bool GameOver => _gameOver;
      

        public static void GameInitiaize(int width, int height, 
            bool versusAI, bool first, int difficulty = 2, int algo = 2)
        {
            _ai = null;
            _gameOver = false;
            _player = Player.Human;
            _boardWidth = width;
            _boardHeight = height;
            _board = new Board(_boardWidth, _boardHeight);

            if (!versusAI) return;
            var diff = (Difficulty)difficulty;
            var alg = (AI.Algorith)algo;
            _ai = new AI(diff, alg);

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
                if (_board.FullBoard || _board.Winner == Player.Human)
                {
                    _gameOver = true;
                    GameIsOver();
                    return true;
                }
            }
            if(_ai != null)
            {
                _board.DropCoin(_player, _ai.FindMove(_board));
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
            Easy = 1,
            Medium = 2,
            Hard = 3
        }
    }
}

