using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class food
    {
        int Height;
        int Width;

        public food(ref Frm_Main main)
        {
            PictureBox Food = new PictureBox();
            Food.Size = new System.Drawing.Size(20, 20);
            Food.BackColor = System.Drawing.Color.Red;
            Height = main.Size.Height;
            Width = main.Size.Width;

            Location=Point.Empty;
            Food.Location = Location;
            Food.Name = "food";
            main.Controls.Add(Food);
        }
        private Point _location = Point.Empty;

        public Point Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = ranlocation();
            }
        }
        private Point ranlocation()
        {
            Random rm = new Random();
            Point loc = new Point( rm.Next(20, Width-20),rm.Next(20, Height - 20));
            return loc;
        }
        public void shift()
        {
            Location =ranlocation();
        }

    }
}
