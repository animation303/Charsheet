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
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuNewSheet_Click(object sender, EventArgs e)
        {
            Random dice = new(Guid.NewGuid().GetHashCode());
            string tty = dice.Next(100000, 999999).ToString();

            string newCharsheetID, newCharsheetTabsID, newCharacterName, newSummaryPageID, newSkillsPageID;

            newCharsheetID = "Charsheet" + tty;
            //newCharacterID = "Character" + tty;
            newCharsheetTabsID = "Sheet" + tty;
            newCharacterName = "New Character";
            newSummaryPageID = "SummaryPage" + tty;
            newSkillsPageID = "SkillsPage" + tty;

            TabPage newCharsheet = new TabPage()
            {
                Name = newCharsheetID,
                Text = newCharacterName
            };
            newChar.TabPages.Add(newCharsheet);

            // tab for actual character sheet
            // TODO: rename these for clarity
            
            TabControl newCharsheetTabs = new TabControl()
            {
                Parent = newCharsheet,
                Name = newCharsheetTabsID,
                Dock = DockStyle.Fill,
                Alignment = TabAlignment.Bottom
            };
            newCharsheet.Controls.Add(newCharsheetTabs);

            TabPage newSummaryPage = new TabPage()

            {
                Name = newSummaryPageID,
                Text = "Summary"
            };
            TabPage newSkillsFeatsPage = new TabPage()
            {
                Name = newSkillsPageID,
                Text = "Skills/Feats"
            };

            TabPage newInventoryPage = new TabPage()
            {
                Name = "newInventoryPage" + dice.Next(100000, 999999).ToString(),
                Text = "Inventory"
             };
                        
            
            newCharsheetTabs.TabPages.Add(newSummaryPage);
            newCharsheetTabs.TabPages.Add(newSkillsFeatsPage);
            

        }
    }
}
