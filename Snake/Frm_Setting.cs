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
    public partial class Frm_Setting : Form
    {
        //Object Form Main
        Frm_Main _frm;    
        
        //List Part of snake Body 
        List<PictureBox> _body;
        
        //Location Snake Head 
        Point _head;

        //Constructor
        public Frm_Setting(ref Frm_Main _frm)
        {
            InitializeComponent();
            this._frm = _frm;
            _head = new Point(15, 230);
            _body = new List<PictureBox>();
            Add();
            _body[0].BackColor = Color.Red;
            Add();
            Add();
            _frm._ShiftFood = TrBarShiftFood.Value;
            _frm._Speed = TrBarSpeed.Value;
            Speed.Enabled = true;
        }

        //change Value ShiftFood
        private void TrBarShiftFood_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = "Shift Food: " + TrBarShiftFood.Value.ToString();
            _frm._ShiftFood = TrBarShiftFood.Value;
        }

        //change Value Speed Snake
        private void TrBarSpeed_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = "Speed: " + TrBarSpeed.Value.ToString();
            _frm._Speed = TrBarSpeed.Value;
            Speed.Interval = 1010 - ((_frm._Speed - 1) * 50);
        }

        //Add Part to Body Snake
        public void Add()
        {
            _head.X += 10;

            if (_head.X > 320)
            {
                _head.X = 0;
            }

            PictureBox _part = new PictureBox();
            _part.Size = new System.Drawing.Size(10, 10);
            //_part.BackColor = System.Drawing.Color.Red;
            _part.Location = new System.Drawing.Point(_head.X, _head.Y);
            _part.BackColor = System.Drawing.Color.Transparent;
            _part.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            _part.Image = Snake.Properties.Resources.HeadD;


            try
            {
                _body[_body.Count - 1].BackColor = System.Drawing.Color.Black;

                _body[_body.Count - 1].Image = null;

            }
            catch (Exception)
            {

            }

            _body.Add(_part);
            Controls.Add(_part);
        }

        //Timer Move Snake
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Move();
        }

        //Move Snake
        public void Move()
        {
            Add();
            Controls.Remove(_body[0]);
            _body.RemoveAt(0);
            //_body[_body.Count - 1].BackColor = Color.Red;
        }

        //Click Start 
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //No Cutting The Snake
            if (rbNCTS.Checked)
            {
                _frm._law = 1;
            }

            //Cutting The Snake
            else if (rbCTS.Checked)
            {
                _frm._law = 2;
            }

            //No Law
            else if (rbNoLaw.Checked)
            {
                _frm._law = 0;
            }

            _frm._wall = chWall.Checked;
            this.Close();
        }

        private void Frm_Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Speed.Enabled = false;
        }
    }
}
