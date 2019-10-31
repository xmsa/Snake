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
        Point Head;
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
        public void move()
        {
            add();
            frm.Controls.Remove(_body[0]);
            _body.RemoveAt(0);
            _body[_body.Count - 1].BackColor = Color.Red;
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
            if (Head.Y > frm.Height-60)
            {
                Head.Y = 0;
            }
            else if (Head.Y < 0)
            {
                Head.Y = frm.Height - 60;

            }
            if (Head.X > frm.Width-60)
            {
                Head.X =0;
            }
            else if (Head.X < 0)
            {
                Head.X = frm.Width - 60;
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
    }
}