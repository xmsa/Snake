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
        //Object Form Main
        Frm_Main _Frm_Main;

        //Object Food
        CFood _food;

        //Object Snake
        CSnake _snake;

        //Location X Food 
        public int _fLx { get; set; }

        //Location X Food 
        public int _fLy { get; set; }

        //Flag Enabled Wall
        public bool _wall { get; set; }

        //Speed Move Snake
        public int _Speed { get; set; }

        //Speed Shift Food
        public int _ShiftFood { get; set; }

        //Game Score
        public int _score { get; set; }

        //Speed Move Snake
        public int _law { get; set; }

        //Constructor
        public Frm_Main()
        {
            new Frm_Login().ShowDialog();
            _Frm_Main = this;
            InitializeComponent();
            PanelEnd.Dock = DockStyle.Fill;
            PanelEnd.Visible = false;
            _food = new CFood(ref _Frm_Main);
            _score = 0;
             _snake=new CSnake (ref _Frm_Main,Keys.D);
            _fLx=_food._location.X;
            _fLy = _food._location.Y;
            new Frm_Setting(ref _Frm_Main ).ShowDialog();
            TimerSpeed.Interval = 200 - ( _Speed * 10);
            TimerShiftFood.Interval = _ShiftFood * 500;
        }

        //Directional Key Detection
        private void Frm_Main_KeyDown(object sender, KeyEventArgs e)
        {
            TimerSpeed.Enabled = true;
            TimerShiftFood.Enabled = true;
            var _keys = e.KeyCode;
            switch (_keys)
            {
                case Keys.Left:
                    _keys = Keys.A;
                    break;
                case Keys.Down:
                    _keys = Keys.S;
                    break;
                case Keys.Right:
                    _keys = Keys.D; 
                    break;
                case Keys.Up:
                    _keys = Keys.W;
                    break;
            }

            switch (_keys)
            {
                case Keys.A:
                    _snake._keys = (_snake._keys != Keys.D) ? Keys.A : Keys.D;
                    break;
                case Keys.S:
                    _snake._keys = (_snake._keys != Keys.W) ? Keys.S : Keys.W;
                    break;
                case Keys.D:
                    _snake._keys = (_snake._keys != Keys.A) ? Keys.D : Keys.A;
                    break;
                case Keys.W:
                    _snake._keys = (_snake._keys != Keys.S) ? Keys.W : Keys.S;
                    break;
            }
        }

        //Timer Move Snake
        private void Timer1_Tick(object sender, EventArgs e)
        {
            _snake._Move(_law);
            _snake.eatfood(ref _food);
        }

        //Timer Shift food
        private void Timer2_Tick(object sender, EventArgs e)
        {
            _food.shift();
            
            _fLx = _food._location.X;
            _fLy = _food._location.Y;
        }

        //click Play Again
        private void PicPlayAgain_Click(object sender, EventArgs e)
        {
            _snake.RemoveSnake();
            PanelEnd.Visible = false;
            _score = 0;

            Lblscore.Text = string.Empty;
            TimerShiftFood.Stop();
            TimerSpeed.Stop();

            _snake = new CSnake(ref _Frm_Main, Keys.D);
            _fLx = _food._location.X;
            _fLy = _food._location.Y;
            _Frm_Main.Visible = false;

            new Frm_Setting(ref _Frm_Main).ShowDialog();

            _Frm_Main.Visible = true;

            TimerSpeed.Interval = 200 - (_Speed * 10);
            TimerShiftFood.Interval = _ShiftFood * 500;
        }
    }
}
