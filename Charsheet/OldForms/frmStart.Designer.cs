namespace Charsheet
{
    partial class frmStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuNewSheet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newChar = new System.Windows.Forms.TabControl();
            this.mainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.AutoSize = false;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewSheet,
            this.mnuSave});
            this.mainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1900, 60);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // mnuNewSheet
            // 
            this.mnuNewSheet.AutoSize = false;
            this.mnuNewSheet.Image = global::Charsheet.Properties.Resources.plus;
            this.mnuNewSheet.Name = "mnuNewSheet";
            this.mnuNewSheet.Size = new System.Drawing.Size(96, 56);
            this.mnuNewSheet.Text = "New";
            this.mnuNewSheet.Click += new System.EventHandler(this.mnuNewSheet_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.AutoSize = false;
            this.mnuSave.Image = global::Charsheet.Properties.Resources.save;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(96, 56);
            this.mnuSave.Text = "Save";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newChar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1900, 911);
            this.panel1.TabIndex = 1;
            // 
            // newChar
            // 
            this.newChar.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.newChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newChar.Location = new System.Drawing.Point(0, 0);
            this.newChar.Name = "newChar";
            this.newChar.SelectedIndex = 0;
            this.newChar.Size = new System.Drawing.Size(1900, 911);
            this.newChar.TabIndex = 0;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1900, 971);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(1918, 1018);
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem mnuNewSheet;
        private ToolStripMenuItem mnuSave;
        private Panel panel1;
        private TabControl newChar;
    }
}