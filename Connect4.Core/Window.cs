using System;
using System.Drawing;
using System.Windows.Forms;

namespace Connect4.Core
{
    public partial class Window : Form
    {
        private bool _firstGame = true, _enabled;
        private PictureBox[,] _field;
        private Image _white, _black;

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
            Radio1P.Checked = true;
            CheckFirstMove.Checked = true;
        }

        private void EnableGame(bool enable)
        {
            _enabled = enable;
            Radio1P.Enabled = Radio2P.Enabled = FieldSizes.Enabled = 
            Difficulty.Enabled = Algorithm.Enabled = CheckFirstMove.Enabled = !enable;
            Field.Enabled = enable;

            if(!enable) Select1P();
            ButtonStart.Text = enable ? "LETS PLAY THIS AGAIN" : "MAY THE BATTLE BEGIN";
        }

        private void Select1P(object sender = null, EventArgs e = null)
        {
            CheckFirstMove.Enabled = Difficulty.Enabled = Algorithm.Enabled = Radio1P.Checked;
        }

        private void SelectField(object sender, EventArgs e)
        {
            switch (FieldSizes.SelectedIndex)
            {
                case 0:
                    FieldWidth.Text = FieldHeight.Text = 5.ToString();
                    break;
                case 1:
                    FieldWidth.Text = FieldHeight.Text = 6.ToString();
                    break;
                case 2:
                    FieldWidth.Text = FieldHeight.Text = 7.ToString();
                    break;
                case 3:
                    FieldWidth.Text = FieldHeight.Text = 8.ToString();
                    break;
                default:
                    FieldWidth.Enabled = FieldHeight.Enabled = true;
                    return;
            }
            FieldWidth.Enabled = FieldHeight.Enabled = false;
        }

        private void ClickStart(object sender, EventArgs e)
        {
            if (!int.TryParse(FieldWidth.Text, out var width) || !int.TryParse(FieldHeight.Text, out var height))
            {
                MessageBox.Show("Неправильно введены размеры поля", "Ошибка ввода", MessageBoxButtons.OK);
                return;
            }
            if (!_enabled)
            {
                Game.GameInitiaize(width, height, 
                    Radio1P.Checked, CheckFirstMove.Checked,
                    Difficulty.SelectedIndex + 1, Algorithm.SelectedIndex);
                InititalizeField(width, height);
                BuildField(Game.Board.Fields);
                EnableGame(true);
            }
            else
                EnableGame(false);
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
            _white = Image.FromFile(@"..\..\Coins\white.png");
            _black = Image.FromFile(@"..\..\Coins\black.png");
            for (int i = 0; i < _fieldHeight; i++)
            {
                for (int j = 0; j < _fieldWidth; j++)
                {
                    _field[i, j] = new PictureBox
                    {
                        Parent = Field,
                        Size = new Size(_cellWidth, _cellHeight),
                        Top = i * _cellHeight,
                        Left = j * _cellWidth,
                        BorderStyle = BorderStyle.Fixed3D,
                        Tag = j,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    if (i != 0) continue;
                    _field[i, j].MouseClick += MakeMoveField;
                    _field[i, j].Cursor = Cursors.Hand;
                    _field[i, j].BackColor = Color.Chartreuse;
                    _field[i, j].Invalidate();
                }
            }
            _firstGame = false;
        }

        private void BuildField(int?[,] field)
        {
            for (int i = 0; i < _fieldWidth; i++)
            for (int j = 0; j < _fieldHeight; j++)
            {
                switch (field[i, j])
                {
                    case (int) Game.Player.Human:
                        _field[j, i].Image = _white;
                        break;
                    case (int) Game.Player.Computer:
                        _field[j, i].Image = _black;
                        break;
                    default:
                        _field[j, i].Image = null;
                        break;
                }
            }
        }

        private void MakeMoveField(object sender, MouseEventArgs e)
        {
            var pos = (int) (sender as Control).Tag;
            if (Game.GameMove(pos, out var field))
                BuildField(field);
            if (Game.GameOver)
                EnableGame(false);
        }
    }
}
