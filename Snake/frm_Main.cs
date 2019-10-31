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
        public Frm_Main()
        {
           // new Frm_Login().ShowDialog();
            _Frm_Main = this;
            InitializeComponent();
            PanelEnd.Dock = DockStyle.Fill;
            PanelEnd.Visible = false;
            _food = new food(ref _Frm_Main);
             _snake=new snake (ref _Frm_Main,'d');

        }

        private void Frm_Main_KeyDown(object sender, KeyEventArgs e)
        {
            char key = Convert.ToChar(e.KeyData);
            timer1.Enabled = true;

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
        }
    }
}
