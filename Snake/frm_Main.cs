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
        public Frm_Main()
        {
           // new Frm_Login().ShowDialog();
            _Frm_Main = this;
            InitializeComponent();
            PanelEnd.Dock = DockStyle.Fill;
            PanelEnd.Visible = false;

        }
    }
}
