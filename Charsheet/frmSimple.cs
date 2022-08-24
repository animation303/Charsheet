using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charsheet
{
    public partial class frmSimple : Form
    {
        public frmSimple()
        {
            InitializeComponent();
        }

        private void frmSimple_Load(object sender, EventArgs e)
        {
            int thisx = this.Location.X;
            this.Location = new Point (thisx, 0);
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            tabMain.Height = this.Height - 200;
        }

    }
}
