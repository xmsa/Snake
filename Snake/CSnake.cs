using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{

    class CSnake
    {
        //Object Form Main 
        Frm_Main _frm;

        //List for Snake Part 
        List<PictureBox> _body;

        //Location Snake Head 
        Point _head;

        //The direction of the snake's movement
        public Keys _keys { get; internal set; }

        //The direction of the snake Head
        Bitmap _imagehead ;

        //Constructor
        public CSnake(ref Frm_Main _frm, Keys _keys)
        {
            this._frm = _frm;
            this._keys = _keys;
            Bitmap _imagehead = Snake.Properties.Resources.HeadD;
            _head = new Point(10, 10);
            _body = new List<PictureBox>();
            Add();
            Add();
            Add();
        }

        //Move Snake
        public void _Move(int _law)
        {
            Add();

            _frm.Controls.Remove(_body[0]);
            _body.RemoveAt(0);
            //_body[_body.Count - 1].BackColor = Color.Red;

            if (_law == 1)
            {
                Law1();
            }
            else if (_law == 2)
            {
                Law2();
            }
        }

        //No Cutting The Snake
        private void Law1()
        {
            int _headX0 = _head.X;
            int _headX1 = _head.X + 20;
            int _headY0 = _head.Y;
            int _headY1 = _head.Y + 20;
            for (int i = _body.Count - 4; i >= 0; i--)
            {
                PictureBox val = _body[i];

                if (_headX0 <= val.Location.X && val.Location.X <= _headX1 &&
                    _headY0 <= val.Location.Y && val.Location.Y <= _headY1)
                {
                    _frm.TimerShiftFood.Enabled = false;
                    _frm.TimerSpeed.Enabled = false;
                    _frm.PanelEnd.Visible = true;
                    _frm.Lbl_star.Text = _frm._score.ToString();

                }
            }
        }

        //Cutting The Snake
        private void Law2()
        {
            int HeadX0 = _head.X;
            int HeadX1 = _head.X + 20;
            int HeadY0 = _head.Y;
            int HeadY1 = _head.Y + 20;
            for (int i = _body.Count - 4; i >= 0; i--)
            {
                PictureBox val = _body[i];

                if (HeadX0 <= val.Location.X && val.Location.X <= HeadX1 && HeadY0 <= val.Location.Y && val.Location.Y <= HeadY1)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        try
                        {
                            _frm.Controls.Remove(_body[j]);
                            _body.RemoveAt(j);
                        }
                        catch (Exception)
                        {
                            return;
                        }
                    }
                    return;
                }
            }
        }

        //Add Part to Snake
        public void Add()
        {
            switch (_keys)
            {
                case Keys.W:
                    _head.Y -= 20;
                    _imagehead = Snake.Properties.Resources.HeadW;
                    break;
                case Keys.S:
                    _head.Y += 20;
                    _imagehead = Snake.Properties.Resources.HeadS;
                    
                    break;
                case Keys.A:
                    _head.X -= 20;
                    _imagehead = Snake.Properties.Resources.HeadA;

                    break;
                case Keys.D:
                    _head.X += 20;
                    _imagehead = Snake.Properties.Resources.HeadD;
                    break;
            }

            if (_frm._wall)
            {
                if (0 > _head.Y || _head.Y > _frm.Height ||
                    0 > _head.X || _head.X > _frm.Width)
                {
                    _frm.TimerShiftFood.Enabled = false;
                    _frm.TimerSpeed.Enabled = false;

                    _frm.PanelEnd.Visible = true;
                    _frm.Lbl_star.Text = _frm._score.ToString();
                    return;
                }
            }
            else
            {
                if (_head.Y > _frm.Height - 60)
                {
                    _head.Y = 0;
                }
                else if (_head.Y < 0)
                {
                    _head.Y = _frm.Height - 60;

                }
                if (_head.X > _frm.Width - 60)
                {
                    _head.X = 0;
                }
                else if (_head.X < 0)
                {
                    _head.X = _frm.Width - 60;
                }
            }

            PictureBox _part = new PictureBox();
            _part.Height = 10;
            _part.Width = 10;
            _part.Size = new System.Drawing.Size(20, 20);
            //_part.BackColor = System.Drawing.Color.Red;
            _part.BackColor = System.Drawing.Color.Transparent;

            _part.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            _part.Image = _imagehead;
            

            _part.Location = new System.Drawing.Point(_head.X, _head.Y);
            try
            {
                _body[_body.Count - 1].BackColor = System.Drawing.Color.Black;
                _body[_body.Count - 1].Image = null;
            }
            catch (Exception)
            {
            }
            _body.Add(_part);
            _frm.Controls.Add(_part);

        }
        
        //Remove All Part of Snake
        public void RemoveSnake()
        {
            while (0 < _body.Count)
            {
                _frm.Controls.Remove(_body[0]);
                _body.Remove(_body[0]);
            }
        }

        //Check Snake Eating
        public void eatfood(ref CFood _food)
        {
            int _x = _head.X;
            int _y = _head.Y;

            if ((_frm._fLx <= _x + 20 && _x + 20 <= _frm._fLx + 20) && (_frm._fLy <= _y + 20 && _y + 20 <= _frm._fLy + 20))
            {
                eating(ref _food);
            }
            else if ((_frm._fLx <= _x && _x <= _frm._fLx + 20) && (_frm._fLy <= _y + 20 && _y + 20 <= _frm._fLy + 20))
            {
                eating(ref _food);
            }
            else if ((_frm._fLx <= _x + 20 && _x + 20 <= _frm._fLx + 20) && (_frm._fLy <= _y && _y <= _frm._fLy + 20))
            {
                eating(ref _food);
            }
            else if ((_frm._fLx <= _x && _x <= _frm._fLx + 20) && (_frm._fLy <= _y && _y <= _frm._fLy + 20))
            {
                eating(ref _food);
            }

        }

        //Snake Eating
        void eating(ref CFood _food)
        {
            Add();
            _food.shift();
            _frm.TimerShiftFood.Stop();
            _frm.TimerShiftFood.Start();
            _frm._fLx = _food._location.X;
            _frm._fLy = _food._location.Y;
            _frm._score++;
            _frm.Lblscore.Text = _frm._score.ToString();
        }
    }
}