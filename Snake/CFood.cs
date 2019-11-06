using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class CFood
    {
        //Object Food
        PictureBox _food;

        //Location Food
        public Point _location { set; get; }

        //Height and Width form
        int _height { set; get; }
        int _width { set; get; }

        //Constructor
        public CFood(ref Frm_Main _frm)
        {
            _food = new PictureBox();
            _food.Size = new System.Drawing.Size(20, 20);
            _food.BackColor = System.Drawing.Color.Transparent;
            _food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            //_food.BackColor = System.Drawing.Color.Red;
            _height = _frm.Size.Height - 60;
            _width = _frm.Size.Width - 60;
            _location = Point.Empty;
            shift();
            _frm.Controls.Add(_food);
        }

        //Return Location Randome
        private Point ranlocation()
        {
            Random rm = new Random();
            Point loc = new Point(rm.Next(20, _width - 20), rm.Next(20, _height - 20));
            return loc;
        }

        //Random picture Food
        private Bitmap RanPicFood()
        {
            Random rn = new Random();
            switch (rn.Next(1, 8))
            {
                case 1:
                    return Snake.Properties.Resources.FoodA;
                case 2:
                    return Snake.Properties.Resources.FoodB;
                case 3:
                    return Snake.Properties.Resources.FoodC;
                case 4:
                    return Snake.Properties.Resources.FoodD;
                case 5:
                    return Snake.Properties.Resources.FoodE;
                case 6:
                    return Snake.Properties.Resources.FoodF;
                default:
                    return Snake.Properties.Resources.FoodG;
            }
        }
        
        //Shift Food
        public void shift()
        {
            _location = ranlocation();
            _food.Location = _location;
            _food.Image =RanPicFood();
            
        }
    }
}
