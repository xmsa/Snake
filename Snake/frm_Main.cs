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
        public int _fLx { get; set; }
        public int _fLy { get; set; }
        public bool Wall { get; set; }
        public int _Speed { get; set; }
        public int _ShiftFood { get; set; }
        public int level { get; set; }
        public int Law { get; set; }

        public Frm_Main()
        {
            new Frm_Login().ShowDialog();
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
            _snake.move(Law);
            _snake.eatfood(ref _food);
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            _food.shift();
            
            _fLx = _food.Location.X;
            _fLy = _food.Location.Y;
        }

        private void PicPlayAgain_Click(object sender, EventArgs e)
        {
            _snake.RemoveSnake();
            PanelEnd.Visible = false;
            level = 0;
            LblLevel.Text = string.Empty;
            TimerShiftFood.Stop();
            TimerSpeed.Stop();
            _snake = new snake(ref _Frm_Main, 'd');
            _fLx = _food.Location.X;
            _fLy = _food.Location.Y;
            _Frm_Main.Visible = false;
            new Frm_Setting(ref _Frm_Main).ShowDialog();
            _Frm_Main.Visible = true;

            TimerSpeed.Interval = 200 - (_Speed * 10);
            TimerShiftFood.Interval = _ShiftFood * 500;

        }
    }
}
