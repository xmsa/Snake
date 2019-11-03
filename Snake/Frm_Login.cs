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
    public partial class Frm_Login : Form
    {
        int count = 0;
        private Point MouseDownLocation;

        public Frm_Login()
        {
            InitializeComponent();
            btnExit.Visible = false;
            btnLogin.Visible = false;
        }

        private void PicSnake1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation.X = e.Location.X;

                if (e.Location.Y>296)
                {
                    MouseDownLocation.Y = 296;
                }
                else
                {
                    MouseDownLocation = e.Location;
                }
            }
        }

        private void PicSnake1_MouseMove(object sender, MouseEventArgs e)
        {
            if (PicSnake1.Top > 145 && PicSnake1.Top < 296)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    PicSnake1.Top = e.Y + PicSnake1.Top - MouseDownLocation.Y;
                }
            }
            else if (PicSnake1.Top > 295)
            {
                btnExit.Visible = true;
                btnLogin.Visible = true;
            }
        }

        private void PicSnake1_Click(object sender, EventArgs e)
        {
            count = 0;
            timer1.Enabled = true;
            timer2.Enabled = false;
            if (PicSnake1.Top < 296)
                PicSnake1.Top = 146;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (count==2)
            {
                timer2.Enabled = true;
                timer1.Enabled = false;
            }
            count++;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (PicSnake1.Top<296)
            {
                PicSnake1.Top += 1;
            }
            else
            {
                timer2.Enabled = false;
                btnExit.Visible = true;
                btnLogin.Visible = true;
            }
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
