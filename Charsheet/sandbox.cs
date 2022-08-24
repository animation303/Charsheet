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
    public partial class sandbox : Form
    {
        static readonly Random dice = new(Guid.NewGuid().GetHashCode());

        public sandbox()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tty = dice.Next(100000, 999999).ToString();
            Panel newPanel = new()
            {
                Name = "Item" + tty,

                Size = new Size(543, 35),
            };
            flowLayoutPanel1.Controls.Add(newPanel);

            CheckBox newCheckbox = new()
            {
                Name = "Extend" + tty,
                Location = new Point(4, 4),
                Size = new Size(27,27),
                Text = "",
                Font = new Font("Segoe MDL2 Assets", 8),
                Appearance = Appearance.Button
            };
            TextBox newItemName = new()
            {
                Name = "Item" + tty,
                Size = new Size(202, 27),
                Location = new Point (43, 4),
                Text = "New Item " + tty
            };
            TextBox NewItemWeight = new()
            {
                Name = "Item" + tty + "Weight",
                Size = new Size(54, 27),
                Location = new Point (250, 4),
                Text = "0"
            };
            TextBox NewItemValue = new()
            {
                Name = "Item" + tty + "Value",
                Size = new Size(54, 27),
                Location = new Point(310, 4),
                Text = "0"
            };
            Label newItemDescLabel = new()
            {
                Name = "lbl" + tty,
                Text = "Description",
                Location = new Point(49, 42),
                Size = new Size(85,25)
            };
            TextBox newItemDesc = new()
            {
                Name = "Item" + tty + "Description",
                Size = new Size(226, 27),
                Location = new Point(138, 38)
            };
            Button newItemDelete = new()
            {
                Size = new Size (27, 27),
                Location = new Point (499, 4),
                Text = "",
                Font = new Font("Segoe MDL2 Assets", 8),
                BackColor = Color.Red,
                FlatStyle = FlatStyle.Popup 
            };
            newPanel.Controls.Add(newCheckbox);
            newPanel.Controls.Add(newItemName);
            newPanel.Controls.Add(NewItemWeight);
            newPanel.Controls.Add(NewItemValue);
            newPanel.Controls.Add(newItemDescLabel);
            newPanel.Controls.Add(newItemDesc);
            newPanel.Controls.Add(newItemDelete);
            newCheckbox.CheckedChanged += (s, e) =>
                {
                    switch (newCheckbox.Checked)
                    {
                        case true:
                            newCheckbox.Text = "";
                            newPanel.Height = 72;
                            break;
                        case false:
                            newCheckbox.Text = "";
                            newPanel.Height = 35;
                            break;
                    }
                };
            newItemDelete.Click += (s, e) =>
                {
                flowLayoutPanel1.Controls.Remove(newPanel);
                };

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string tty = dice.Next(100000, 999999).ToString();
            CheckBox newCheckbox = new()
            {
                Name = "Bag" + tty,
                Location = new Point(4, 4),
                Size = new Size(440, 30),
                Text = "",
                Appearance = Appearance.Button
            };
            TextBox newBagName = new()
            {
                Name = "BagName" + tty,
                Location = new Point(20, 4),
                Size = new Size(300, 25),
                Text = "New Bag"
            };
            flowLayoutPanel2.Controls.Add(newCheckbox);
            newCheckbox.Controls.Add(newBagName);
            this.ActiveControl = newBagName;
            newBagName.Leave += (s, e) =>
            {
                newCheckbox.Text = newBagName.Text;
                newCheckbox.Controls.Remove(newBagName);
            };
            newBagName.KeyPress += (s, e) =>
            {
                if (e.KeyChar == Convert.ToChar(Keys.Return))
                {
                    newCheckbox.Text = newBagName.Text;
                    newCheckbox.Controls.Remove(newBagName);
                }
            };
        }


        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
