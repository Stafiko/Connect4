using System;
using System.Drawing;
using System.Windows.Forms;

namespace Connect4.Core
{
    public partial class Window : Form
    {
        private bool _firstGame = true, _enabled;
        private PictureBox[,] _field;
        private Image _red, _yellow, _empty;

        private int
            _cellWidth,
            _cellHeight,
            _fieldWidth,
            _fieldHeight;

        public Window()
        {
            InitializeComponent();

            FieldSizes.SelectedIndex = 0;
            Difficulty.SelectedIndex = 1;
            Algorithm.SelectedIndex = 1;
            WinCount.SelectedIndex = 0;
            Radio1P.Checked = true;
            CheckFirstMove.Checked = true;
        }

        private void EnableGame(bool enable)
        {
            _enabled = enable;
            Radio1P.Enabled = Radio2P.Enabled = FieldSizes.Enabled = WinCount.Enabled = 
            Difficulty.Enabled = Algorithm.Enabled = CheckFirstMove.Enabled = !enable;
            Field.Enabled = enable;

            if(!enable) Selected1P();
            ButtonStart.Text = enable ? "LETS PLAY THIS AGAIN" : "MAY THE BATTLE BEGIN";
        }


        private void SelectedWinCount(object sender, EventArgs e)
        {
            var selected = WinCount.SelectedIndex;
            if (selected < 3) WinCountInput.Text = (selected + 4).ToString();
            else
            {
                WinCountInput.Enabled = true;
                return;
            }
            WinCountInput.Enabled = false;
        }

        private void Selected1P(object sender = null, EventArgs e = null)
        {
            CheckFirstMove.Enabled = Difficulty.Enabled = Algorithm.Enabled = Radio1P.Checked;
        }

        private void SelectedField(object sender, EventArgs e)
        {
            switch (FieldSizes.SelectedIndex)
            {
                case 0:
                    FieldWidth.Text = 7.ToString();
                    FieldHeight.Text = 6.ToString();
                    break;
                case 1:
                    FieldWidth.Text = 8.ToString();
                    FieldHeight.Text = 7.ToString();
                    break;
                case 2:
                    FieldWidth.Text = 9.ToString();
                    FieldHeight.Text = 7.ToString();
                    break;
                case 3:
                    FieldWidth.Text = 10.ToString();
                    FieldHeight.Text = 7.ToString();
                    break;
                default:
                    FieldWidth.Enabled = FieldHeight.Enabled = true;
                    return;
            }
            FieldWidth.Enabled = FieldHeight.Enabled = false;
        }

        private void ClickedStart(object sender, EventArgs e)
        {
            if (!int.TryParse(FieldWidth.Text, out var width) || 
                !int.TryParse(FieldHeight.Text, out var height) ||
                !int.TryParse(WinCountInput.Text, out var toWin))
            {
                MessageBox.Show("Неправильно введены игровые настройки", "Ошибка ввода", MessageBoxButtons.OK);
                return;
            }

            if (!_enabled)
            {
                Game.Initiaize(width, height, 
                    Radio1P.Checked, CheckFirstMove.Checked,
                    toWin, Difficulty.SelectedIndex + 1, Algorithm.SelectedIndex);
                InititalizeField(width, height);
                BuildField(Game.Board.Fields);
                EnableGame(true);
            }
            else EnableGame(false);
        }

        private void InititalizeField(int width, int height)
        {
            if (!_firstGame)
                foreach (var f in _field)
                    f.Dispose();

            _fieldWidth = width;
            _fieldHeight = height;
            _cellWidth = Field.Width / width;
            _cellHeight = Field.Height / height;
            _field = new PictureBox[_fieldHeight, _fieldWidth];

            _red = Image.FromFile(@"..\..\Coins\red.png");
            _yellow = Image.FromFile(@"..\..\Coins\yellow.png");
            _empty = Image.FromFile(@"..\..\Coins\empty.png");

            for (int i = 0; i < _fieldHeight; i++)
            for (int j = 0; j < _fieldWidth; j++)
            {
                _field[i, j] = new PictureBox
                {
                    Parent = Field,
                    Size = new Size(_cellWidth, _cellHeight),
                    Top = i * _cellHeight,
                    Left = j * _cellWidth,
                    BorderStyle = BorderStyle.None,
                    Tag = j,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.RoyalBlue
                };
                if (i != 0) continue;
                _field[i, j].MouseClick += MakeMoveField;
                _field[i, j].Cursor = Cursors.Hand;
                _field[i, j].BackColor = Color.Chartreuse;
                _field[i, j].Invalidate();
            }
            _firstGame = false;
        }

        private void BuildField(int?[,] field)
        {
            for (int i = 0; i < _fieldWidth; i++)
            for (int j = 0; j < _fieldHeight; j++)
                _field[j, i].Image = field[i, j] == (int)Game.Player.Human
                    ? _red
                    : field[i, j] == (int)Game.Player.Computer
                        ? _yellow
                        : _empty;
        }

        private void MakeMoveField(object sender, MouseEventArgs e)
        {
            var pos = (int) (sender as Control).Tag;
            if (Game.Move(pos, out var field)) BuildField(field);
            if (Game.GameOver) EnableGame(false);
        }
    }
}
