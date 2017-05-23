namespace Connect4.Core
{
    public class Board
    {
        private readonly int?[,] _fields;
        public int?[,] Fields => _fields;
        private Game.Player? _winner;
        private bool _changed;
        private int _colums;
        private int _rows;
        private int _line = 4;

        public int Columns => _colums;
        public int Rows => _rows;

        public Board(int width, int height, int line = 4)
        {
            _line = line;
            _colums = width;
            _rows = height;
            _fields = new int?[_colums, _rows];
        }

        public bool MakeMove(int column, bool drop = false, Game.Player player = Game.Player.Human)
        {
            var row = 0; 
            while (row < Rows && !_fields[column, row].HasValue)
                row++;

            if (row != 0 && drop) _fields[column, row - 1] = (int)player;
            else if (row - 1 != _rows && !drop) _fields[column, row] = null;
            else return false;
            _changed = true;
            return true;
        }

        public Game.Player? Winner
        {
            get
            {
                if (!_changed) return _winner;

                _changed = false;
                for (int i = 0; i < _colums; i++)
                for (int j = 0; j < _rows; j++)
                {
                    if (!_fields[i, j].HasValue) continue;

                    var horizontal = i + _line - 1 < _colums;
                    var vertical = j + _line - 1 < _rows;

                    if (!horizontal && !vertical) continue;

                    var forwardDiagonal = horizontal && vertical;
                    var backwardDiagonal = vertical && i - _line - 1 >= 0;

                    for (int k = 1; k < _line; k++)
                    {
                        horizontal = horizontal && _fields[i, j] == _fields[i + k, j];
                        vertical = vertical && _fields[i, j] == _fields[i, j + k];
                        forwardDiagonal = forwardDiagonal && _fields[i, j] == _fields[i + k, j + k];
                        backwardDiagonal = backwardDiagonal && _fields[i, j] == _fields[i - k, j + k];

                        if (!horizontal && !vertical && !forwardDiagonal && !backwardDiagonal) break;
                    }

                    if (!horizontal && !vertical && !forwardDiagonal && !backwardDiagonal) continue;
                    _winner = (Game.Player?) _fields[i, j];
                    return _winner;
                }
                _winner = null;
                return _winner;
            }
        }

        public bool FullBoard
        {
            get
            {
                for (int i = 0; i < Columns; i++)
                    if (!_fields[i, 0].HasValue) return false;
                return true;
            }
        }
    }
}
