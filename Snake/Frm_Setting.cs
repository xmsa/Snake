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
        Frm_Main _frm;
        List<PictureBox> _body;
        Point _head;
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

        private void TrBarShiftFood_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = "Shift Food: " + TrBarShiftFood.Value.ToString();
            _frm._ShiftFood = TrBarShiftFood.Value;
        }

        private void TrBarSpeed_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = "Speed: " + TrBarSpeed.Value.ToString();
            _frm._Speed = TrBarSpeed.Value;
            Speed.Interval = 200 - (TrBarSpeed.Value * 10);
        }

        public void Add()
        {
            _head.X += 10;

            if (_head.X > 320)
            {
                _head.X = 0;
            }

            PictureBox _part = new PictureBox();
            _part.Size = new System.Drawing.Size(10, 10);
            _part.BackColor = System.Drawing.Color.Red;
            _part.Location = new System.Drawing.Point(_head.X, _head.Y);

            try
            {
                _body[_body.Count - 1].BackColor = System.Drawing.Color.Black;
            }
            catch (Exception)
            {

            }

            _body.Add(_part);
            Controls.Add(_part);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Move();
        }

        public void Move()
        {
            Add();
            Controls.Remove(_body[0]);
            _body.RemoveAt(0);
            _body[_body.Count - 1].BackColor = Color.Red;
        }

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
    }
}
