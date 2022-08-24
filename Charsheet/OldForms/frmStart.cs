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

        private void buildSummaryPage(TabPage tabid, string id)
        {
            FlowLayoutPanel flowLayoutPanel1 = new()
            {
                Location = new System.Drawing.Point(15, 20),
                Name = "flowLayoutPanel1",
                Size = new System.Drawing.Size(1855, 176),
                TabIndex = 0
            };
            tabid.Controls.Add(flowLayoutPanel1);
            Label arse = new Label()
            {
                Text = "Farts XD",
                Size = new System.Drawing.Size(120, 32),
                Location = new System.Drawing.Point(12, 20)
            };

            flowLayoutPanel1.Controls.Add(arse);

            
        }
        private void buildSkillsPage(string tabid, string id)
        {

        }
        private void buildInventoryPage(string tabid, string id)
        {

        }

        private void mnuNewSheet_Click(object sender, EventArgs e)
        {
            Random dice = new(Guid.NewGuid().GetHashCode());
            string tty = dice.Next(100000, 999999).ToString();

            string newCharsheetID, newCharsheetTabsID, newCharacterName, newSummaryPageID, newSkillsPageID, newInventoryPageID;

            newCharsheetID = "Charsheet" + tty;
            //newCharacterID = "Character" + tty;
            newCharsheetTabsID = "Sheet" + tty;
            newCharacterName = "New Character";
            newSummaryPageID = "SummaryPage" + tty;
            newSkillsPageID = "SkillsPage" + tty;
            newInventoryPageID = "newInventoryPage" + tty;

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
                Name = "tabSummary" + newSummaryPageID,
                Text = "Summary " + tty
            };
            TabPage newSkillsPage = new TabPage()
            {
                Name = "tabSkills" + newSkillsPageID,
                Text = "Skills/Feats " + tty
            };

            TabPage newInventoryPage = new TabPage()
            {
                Name = "tabInventory" + newInventoryPageID,
                Text = "Inventory " + tty 
             };
                        
            
            newCharsheetTabs.TabPages.Add(newSummaryPage);
            buildSummaryPage(newSummaryPage, tty);
            newCharsheetTabs.TabPages.Add(newSkillsPage);
            // buildSkillsPage(newSkillsPage.Name, newtty);
            newCharsheetTabs.TabPages.Add(newInventoryPage);
            // buildInventoryPage(newInventoryPage.Name, tty);

        }
    }
}
