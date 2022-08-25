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
    public partial class newItemDialog : Form
    {
        private sandbox fromForm { get; set; }

        public newItemDialog(sandbox thatForm)
        {
            InitializeComponent();
            fromForm = thatForm;
        }

        private void newItemDialog_Load(object sender, EventArgs e)
        {
            switch (this.Tag)
            { 
                case "Bag":
                    this.Text = "Add new storage item";

                    Label newlabel = new() { Text = "New Bag Name (Optional)", Location = new Point(55, 63), Size = new Size(185, 20) };
                    TextBox bagName = new() { Location = new Point(246, 60), Size = new Size(223, 28) };
                    Label newlabel2 = new() { Text = "New Bag Type (Required)", Location = new Point(55, 96), Size = new Size(185, 20) };
                    ComboBox bagType = new() { Location = new Point(246, 93), Size = new Size(223, 28) };
                    bagType.Items.AddRange(new object[] {"Backpack","Handy Haversack","Quiver","Efficient Quiver","Sack"});
                    Button okButton = new() { DialogResult = DialogResult.OK, Location = new Point(127, 200), Text = "Add", Size = new Size(94, 29) };
                    Button cancelButton = new() { DialogResult = DialogResult.Cancel, Location = new Point(307, 200), Text = "Cancel", Size= new Size(94, 29)};
                    bagType.SelectedIndex = 0;
                    this.Controls.Add(newlabel);
                    this.Controls.Add(bagName);
                    this.Controls.Add(newlabel2);
                    this.Controls.Add(bagType);
                    this.Controls.Add(okButton);
                    this.Controls.Add(cancelButton);
                    var functionForm = Application.OpenForms.OfType<sandbox>().Single();

                    okButton.Click += (s, e) =>
                    {
                        fromForm.newBag(bagType.Text, bagName.Text);
                        this.Close();
                    };
                    break;
            }
        }
    }
}
