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

        public int Columns => _colums;
        public int Rows => _rows;

        public Board(int width, int height)
        {
            _colums = width;
            _rows = height;
            _fields = new int?[_colums, _rows];
        }

        public bool ColumnFree(int column)
        {
            return !_fields[column, 0].HasValue;
        }

        public bool DropCoin(Game.Player player, int column)
        {
            var row = 0;
            while (row < Rows && !_fields[column, row].HasValue)
                row++;

            if (row == 0) return false;
            _fields[column, row - 1] = (int)player;
            _changed = true;
            return true;
        }

        public bool RemoveCoin(int column)
        {
            var row = 0;
            while (row < Rows - 1 && !_fields[column, row].HasValue)
                row++;

            if (row == Rows) return false;
            _fields[column, row] = null;
            _changed = true;
            return true;
        }

        public Game.Player? Winner
        {
            get
            {
                if (!_changed)
                    return _winner;

                _changed = false;
                for (int i = 0; i < Columns; i++)
                {
                    for (int j = 0; j < Rows; j++)
                    {
                        if (!_fields[i, j].HasValue)
                            continue;

                        bool horizontal = i + 3 < Columns;
                        bool vertical = j + 3 < Rows;

                        if (!horizontal && !vertical)
                            continue;

                        bool forwardDiagonal = horizontal && vertical;
                        bool backwardDiagonal = vertical && i - 3 >= 0;

                        for (int k = 1; k < 4; k++)
                        {
                            horizontal = horizontal && _fields[i, j] == _fields[i + k, j];
                            vertical = vertical && _fields[i, j] == _fields[i, j + k];
                            forwardDiagonal = forwardDiagonal && _fields[i, j] == _fields[i + k, j + k];
                            backwardDiagonal = backwardDiagonal && _fields[i, j] == _fields[i - k, j + k];
                            if (!horizontal && !vertical && !forwardDiagonal && !backwardDiagonal)
                                break;
                        }

                        if (horizontal || vertical || forwardDiagonal || backwardDiagonal)
                        {
                            _winner = (Game.Player?) _fields[i, j];
                            return _winner;
                        }
                    }
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

        public int EmptyFields
        {
            get
            {
                var count = 0;
                for (int i = 0; i < Columns; i++)
                    if (!_fields[i, 0].HasValue) count++;
                return count;
            }
        }
    }
}
