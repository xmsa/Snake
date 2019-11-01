using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Frm_Main : Form
    {
        Frm_Main _Frm_Main;
        food _food;
        snake _snake;
        int _fLx;
        int _fLy;
        public int _Speed;
        public int _ShiftFood;
        int level;
        public Frm_Main()
        {
            //new Frm_Login().ShowDialog();
            _Frm_Main = this;
            InitializeComponent();
            PanelEnd.Dock = DockStyle.Fill;
            PanelEnd.Visible = false;
            _food = new food(ref _Frm_Main);
            level = 0;
             _snake=new snake (ref _Frm_Main,'d');
            _fLx=_food.Location.X;
            _fLy = _food.Location.Y;
            new Frm_Setting(ref _Frm_Main ).ShowDialog();
            TimerSpeed.Interval = 200 - ( _Speed * 10);
            TimerShiftFood.Interval = _ShiftFood * 500;
        }

        private void Frm_Main_KeyDown(object sender, KeyEventArgs e)
        {
            char key='a';
            try
            {
                key = Convert.ToChar(e.KeyData);

            }
            catch (Exception)
            {
                return;
            }
            TimerSpeed.Enabled = true;
            TimerShiftFood.Enabled = true;
            switch (key)
            {
                case 'A':
                    _snake.Direction = (_snake.Direction != 'd') ? 'a' : 'd';
                    break;
                case 'S':
                    _snake.Direction = (_snake.Direction != 'w') ? 's' : 'w';
                    break;
                case 'D':
                    _snake.Direction = (_snake.Direction != 'a') ? 'd' : 'a';
                    break;
                case 'W':
                    _snake.Direction = (_snake.Direction != 's') ? 'w' : 's';
                    break;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            _snake.move();
            eatfoot();
        }

        void eatfoot()
        {
            int x=_snake.Head.X;
            int y = _snake.Head.Y;

            if ((_fLx <= x + 20 && x + 20 <= _fLx + 20) && (_fLy <= y + 20 && y + 20 <= _fLy + 20))
            {
                eating();
            }
            else if ((_fLx <= x && x <= _fLx + 20) && (_fLy <= y + 20 && y + 20 <= _fLy + 20))
            {
                eating();
            }
            else if ((_fLx <= x + 20 && x + 20 <= _fLx + 20) && (_fLy <= y && y <= _fLy + 20))
            {
                eating();
            }
            else if ((_fLx <= x && x <= _fLx + 20) && (_fLy <= y && y <= _fLy + 20))
            {
                eating();
            }

        }
        void eating()
        {
            _snake.add();
            _food.shift();
            TimerShiftFood.Stop();
            TimerShiftFood.Start();
            _fLx = _food.Location.X;
            _fLy = _food.Location.Y;
            level++;
            LblLevel.Text =  level.ToString();
            
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            _food.shift();
            
            _fLx = _food.Location.X;
            _fLy = _food.Location.Y;
        }

       
    }
}
