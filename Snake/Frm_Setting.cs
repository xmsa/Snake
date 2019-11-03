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
        Frm_Main frm;
        List<PictureBox> _body;
        Point Head;
        public Frm_Setting(ref Frm_Main _frm )
        {
            InitializeComponent();
            frm = _frm;
            Head = new Point(15, 230);
            _body = new List<PictureBox>();
            add();
            _body[0].BackColor = Color.Red;
            add();
            add();
            frm._ShiftFood = TrBarShiftFood.Value;
            frm._Speed = TrBarSpeed.Value;
            Speed.Enabled = true;
            

        }

        private void TrBarShiftFood_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = "Shift Food: " + TrBarShiftFood.Value.ToString();
            frm._ShiftFood = TrBarShiftFood.Value;
        }

        private void TrBarSpeed_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = "Speed: "+TrBarSpeed.Value.ToString();
            frm._Speed = TrBarSpeed.Value;
            Speed.Interval = 200 - (TrBarSpeed.Value * 10);


        }

        public void add()
        {
            Head.X += 10;

            if (Head.X > 320)
            {
                Head.X = 0;
            }
            PictureBox part = new PictureBox();
            part.Size = new System.Drawing.Size(10, 10);
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
            Controls.Add(part);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            move();
        }
        public void move()
        {
            add();
            Controls.Remove(_body[0]);
            _body.RemoveAt(0);
            _body[_body.Count - 1].BackColor = Color.Red;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //No Cutting The Snake
            if (rbNCTS.Checked)
            {
                frm.Law = 1;
            }
            //Cutting The Snake
            else if (rbCTS.Checked)
            {
                frm.Law = 2;
            }
            else if (rbNoLaw.Checked)
            {
                frm.Law = 0;
            }
            this.Close();

        }

        
    }
}
