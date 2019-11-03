using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{

    class snake
    {
        Frm_Main frm;
        List<PictureBox> _body;
        public Point Head;
        public char Direction;
        public snake(ref Frm_Main _frm, char _Direction)
        {
            frm = _frm;
            Direction = _Direction;
            Head = new Point(10, 10);
            _body = new List<PictureBox>();
            add();
            _body[0].BackColor = Color.Red;
            add();
            add();


        }
        public void move(int _law)
        {
            add();

            frm.Controls.Remove(_body[0]);
            _body.RemoveAt(0);
            _body[_body.Count - 1].BackColor = Color.Red;

            if (_law == 1)
            {
                law1();
            }
            else if (_law == 2)
            {
                law2();
            }
        }
        //Cutting The Snake
        private void law2()
        {
            int HeadX0 = Head.X;
            int HeadX1 = Head.X + 20;
            int HeadY0 = Head.Y;
            int HeadY1 = Head.Y + 20;
            for (int i = _body.Count - 4; i >= 0; i--)
            {
                PictureBox val = _body[i];

                if (HeadX0 <= val.Location.X && val.Location.X <= HeadX1 && HeadY0 <= val.Location.Y && val.Location.Y <= HeadY1)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        try
                        {
                            frm.Controls.Remove(_body[j]);
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

        //No Cutting The Snake

        private void law1()
        {
            int HeadX0 = Head.X;
            int HeadX1 = Head.X + 20;
            int HeadY0 = Head.Y;
            int HeadY1 = Head.Y + 20;
            for (int i = _body.Count - 4; i >= 0; i--)
            {
                PictureBox val = _body[i];

                if (HeadX0 <= val.Location.X && val.Location.X <= HeadX1 && HeadY0 <= val.Location.Y && val.Location.Y <= HeadY1)
                {
                    frm.TimerShiftFood.Enabled = false;
                    frm.TimerSpeed.Enabled = false;
                    frm.PanelEnd.Visible = true;
                    frm.Lbl_star.Text = frm.level.ToString();

                }
            }
        }

        public void add()
        {

            switch (Direction)
            {
                case 'w':
                    Head.Y -= 20;
                    break;
                case 's':
                    Head.Y += 20;
                    break;
                case 'a':
                    Head.X -= 20;
                    break;
                case 'd':
                    Head.X += 20;
                    break;
            }
            if (frm.Wall)
            {
                if (0 > Head.Y || Head.Y > frm.Height || 0 > Head.X || Head.X > frm.Width)
                {
                    frm.TimerShiftFood.Enabled = false;
                    frm.TimerSpeed.Enabled = false;

                    frm.PanelEnd.Visible = true;
                    frm.Lbl_star.Text = frm.level.ToString();
                    return;
                }
            }
            else
            {
                if (Head.Y > frm.Height - 60)
                {
                    Head.Y = 0;
                }
                else if (Head.Y < 0)
                {
                    Head.Y = frm.Height - 60;

                }
                if (Head.X > frm.Width - 60)
                {
                    Head.X = 0;
                }
                else if (Head.X < 0)
                {
                    Head.X = frm.Width - 60;
                }
            }


            PictureBox part = new PictureBox();
            part.Height = 10;
            part.Width = 10;
            part.Size = new System.Drawing.Size(20, 20);
            part.BackColor = System.Drawing.Color.Red;
            part.Location = new System.Drawing.Point(Head.X, Head.Y);
            try
            {
                _body[_body.Count - 1].BackColor = System.Drawing.Color.Black;
            }
            catch (Exception)
            {
            }
            _body.Add(part);
            frm.Controls.Add(part);

        }
        public void RemoveSnake()
        {
            while (0 < _body.Count)
            {
                frm.Controls.Remove(_body[0]);
                _body.Remove(_body[0]);
            }

        }
        public void eatfood(ref food _food)
        {
            int x = Head.X;
            int y = Head.Y;

            if ((frm._fLx <= x + 20 && x + 20 <= frm._fLx + 20) && (frm._fLy <= y + 20 && y + 20 <= frm._fLy + 20))
            {
                eating(ref _food);
            }
            else if ((frm._fLx <= x && x <= frm._fLx + 20) && (frm._fLy <= y + 20 && y + 20 <= frm._fLy + 20))
            {
                eating(ref _food);
            }
            else if ((frm._fLx <= x + 20 && x + 20 <= frm._fLx + 20) && (frm._fLy <= y && y <= frm._fLy + 20))
            {
                eating(ref _food);
            }
            else if ((frm._fLx <= x && x <= frm._fLx + 20) && (frm._fLy <= y && y <= frm._fLy + 20))
            {
                eating(ref _food);
            }

        }
        void eating(ref food _food)
        {
            add();
            _food.shift();
            frm.TimerShiftFood.Stop();
            frm.TimerShiftFood.Start();
            frm._fLx = _food.Location.X;
            frm._fLy = _food.Location.Y;
            frm.level++;
            frm.LblLevel.Text = frm.level.ToString();

        }
    }
}