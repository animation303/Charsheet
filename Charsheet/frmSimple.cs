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
        static readonly Random dice = new(Guid.NewGuid().GetHashCode());
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
               
        private void btnNewFeat_Click(object sender, EventArgs e)
        {
            string tty = dice.Next(100000, 999999).ToString();
            Panel newFeatPanel = new()
            {
                Name = "Feat" + tty,
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(525, 115),
            };
            flpFeats.Controls.Add(newFeatPanel);

            CheckBox newExtendButton = new()
            {
                Name = "FeatExtend" + tty,
                Location = new Point(4, 4),
                Size = new Size(27, 27),
                Text = "",
                Font = new Font("Segoe MDL2 Assets", 8),
                Appearance = Appearance.Button,
                Checked = true
            };
            Label newFeatNameLabel = new()
            {
                Name = "lbl" + tty,
                Text = "Name",
                Location = new Point(70, 8),
                Size = new Size(49, 20)
            };
            TextBox newFeatName = new()
            {
                Name = "Feat" + tty + "Name",
                Text = "New Feat " + tty,
                Location = new Point(125, 5),
                Size = new Size(350, 27)
            };
            Label newFeatDescLabel = new()
            {
                Name = "lbl" + tty,
                Text = "Description",
                Location = new Point(35, 55),
                Size = new Size(85, 20)
            };
            TextBox newFeatDesc = new()
            {
                Name = "Feat" + tty + "Desc",
                Text = "Feat " + tty + " Description",
                Multiline = true,
                Location = new Point(125, 50),
                Size = new Size(350, 56)
            };
            Button newFeatDelete = new()
            {
                Text = "",
                Location = new Point(480, 4),
                Size = new Size(32, 29),
                Font = new Font("Segoe MDL2 Assets", 8),
                BackColor = Color.Red,
                FlatStyle = FlatStyle.Popup
            };

            newFeatPanel.Controls.Add(newExtendButton);
            newFeatPanel.Controls.Add(newFeatNameLabel);
            newFeatPanel.Controls.Add(newFeatName);
            newFeatPanel.Controls.Add(newFeatDescLabel);
            newFeatPanel.Controls.Add(newFeatDesc);
            newFeatPanel.Controls.Add(newFeatDelete);

            newExtendButton.CheckedChanged += (s, e) =>
            {
                switch (newExtendButton.Checked)
                {
                    case true:
                        newExtendButton.Text = "";
                        newFeatPanel.Height = 115;
                        break;
                    case false:
                        newExtendButton.Text = "";
                        newFeatPanel.Height = 40;
                        break;
                }
            };

            newFeatDelete.Click += (s, e) =>
            {
                flpFeats.Controls.Remove(newFeatPanel);
            };
        }
    }
}
