namespace Charsheet
{
    partial class Form1
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
            this.panMeleeWeapons = new System.Windows.Forms.Panel();
            this.btnNewMeleeWeapon = new System.Windows.Forms.Button();
            this.tabMeleeWeapons = new System.Windows.Forms.TabControl();
            this.tabMelee0 = new System.Windows.Forms.TabPage();
            this.comMelee0DamageDie = new System.Windows.Forms.ComboBox();
            this.nudMelee0DmgMod = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblMelee0AtkMod = new System.Windows.Forms.Label();
            this.btnMelee0DmgRoll = new System.Windows.Forms.Button();
            this.btnMelee0AtkRoll = new System.Windows.Forms.Button();
            this.lblMelee0Lbs = new System.Windows.Forms.Label();
            this.lblMelee0Feet = new System.Windows.Forms.Label();
            this.nudMelee0Reach = new System.Windows.Forms.NumericUpDown();
            this.comMelee0Size = new System.Windows.Forms.ComboBox();
            this.btnMelee0Delete = new System.Windows.Forms.Button();
            this.txtMelee0SpecProp = new System.Windows.Forms.TextBox();
            this.lblMelee0SpecPropHead = new System.Windows.Forms.Label();
            this.txtMelee0Weight = new System.Windows.Forms.TextBox();
            this.lblMelee0WeightHeader = new System.Windows.Forms.Label();
            this.lblMelee0Notes = new System.Windows.Forms.Label();
            this.txtMelee0Hardness = new System.Windows.Forms.TextBox();
            this.lblMelee0HardHeader = new System.Windows.Forms.Label();
            this.lblMelee0ReachHeader = new System.Windows.Forms.Label();
            this.lblMelee0SizeHeader = new System.Windows.Forms.Label();
            this.comMelee0CritMulti = new System.Windows.Forms.ComboBox();
            this.comMelee0Crit = new System.Windows.Forms.ComboBox();
            this.lblMelee0DmgPlus = new System.Windows.Forms.Label();
            this.txtMelee0DieCount = new System.Windows.Forms.TextBox();
            this.comMelee0Type = new System.Windows.Forms.ComboBox();
            this.txtMelee0Name = new System.Windows.Forms.TextBox();
            this.lblMelee0CritHeader = new System.Windows.Forms.Label();
            this.lblMelee0DmgHeader = new System.Windows.Forms.Label();
            this.lblMelee0TypeHeader = new System.Windows.Forms.Label();
            this.lblMelee0NameHeader = new System.Windows.Forms.Label();
            this.txtMelee0Notes = new System.Windows.Forms.TextBox();
            this.lblMelee0Crit = new System.Windows.Forms.Label();
            this.panMeleeWeapons.SuspendLayout();
            this.tabMeleeWeapons.SuspendLayout();
            this.tabMelee0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMelee0DmgMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMelee0Reach)).BeginInit();
            this.SuspendLayout();
            // 
            // panMeleeWeapons
            // 
            this.panMeleeWeapons.Controls.Add(this.btnNewMeleeWeapon);
            this.panMeleeWeapons.Controls.Add(this.tabMeleeWeapons);
            this.panMeleeWeapons.Location = new System.Drawing.Point(10, 71);
            this.panMeleeWeapons.Name = "panMeleeWeapons";
            this.panMeleeWeapons.Size = new System.Drawing.Size(780, 308);
            this.panMeleeWeapons.TabIndex = 202;
            // 
            // btnNewMeleeWeapon
            // 
            this.btnNewMeleeWeapon.Location = new System.Drawing.Point(304, 260);
            this.btnNewMeleeWeapon.Name = "btnNewMeleeWeapon";
            this.btnNewMeleeWeapon.Size = new System.Drawing.Size(171, 41);
            this.btnNewMeleeWeapon.TabIndex = 202;
            this.btnNewMeleeWeapon.Text = "Add Melee Weapon";
            this.btnNewMeleeWeapon.UseVisualStyleBackColor = true;
            // 
            // tabMeleeWeapons
            // 
            this.tabMeleeWeapons.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabMeleeWeapons.Controls.Add(this.tabMelee0);
            this.tabMeleeWeapons.Location = new System.Drawing.Point(0, 0);
            this.tabMeleeWeapons.Name = "tabMeleeWeapons";
            this.tabMeleeWeapons.SelectedIndex = 0;
            this.tabMeleeWeapons.Size = new System.Drawing.Size(779, 257);
            this.tabMeleeWeapons.TabIndex = 201;
            // 
            // tabMelee0
            // 
            this.tabMelee0.Controls.Add(this.txtMelee0Weight);
            this.tabMelee0.Controls.Add(this.comMelee0DamageDie);
            this.tabMelee0.Controls.Add(this.lblMelee0CritHeader);
            this.tabMelee0.Controls.Add(this.lblMelee0Crit);
            this.tabMelee0.Controls.Add(this.nudMelee0DmgMod);
            this.tabMelee0.Controls.Add(this.comMelee0Crit);
            this.tabMelee0.Controls.Add(this.numericUpDown1);
            this.tabMelee0.Controls.Add(this.comMelee0CritMulti);
            this.tabMelee0.Controls.Add(this.btnMelee0DmgRoll);
            this.tabMelee0.Controls.Add(this.btnMelee0AtkRoll);
            this.tabMelee0.Controls.Add(this.lblMelee0AtkMod);
            this.tabMelee0.Controls.Add(this.lblMelee0Lbs);
            this.tabMelee0.Controls.Add(this.lblMelee0Feet);
            this.tabMelee0.Controls.Add(this.nudMelee0Reach);
            this.tabMelee0.Controls.Add(this.comMelee0Size);
            this.tabMelee0.Controls.Add(this.btnMelee0Delete);
            this.tabMelee0.Controls.Add(this.txtMelee0SpecProp);
            this.tabMelee0.Controls.Add(this.lblMelee0SpecPropHead);
            this.tabMelee0.Controls.Add(this.lblMelee0WeightHeader);
            this.tabMelee0.Controls.Add(this.lblMelee0Notes);
            this.tabMelee0.Controls.Add(this.txtMelee0Hardness);
            this.tabMelee0.Controls.Add(this.lblMelee0HardHeader);
            this.tabMelee0.Controls.Add(this.lblMelee0ReachHeader);
            this.tabMelee0.Controls.Add(this.lblMelee0SizeHeader);
            this.tabMelee0.Controls.Add(this.lblMelee0DmgPlus);
            this.tabMelee0.Controls.Add(this.txtMelee0DieCount);
            this.tabMelee0.Controls.Add(this.comMelee0Type);
            this.tabMelee0.Controls.Add(this.txtMelee0Name);
            this.tabMelee0.Controls.Add(this.lblMelee0DmgHeader);
            this.tabMelee0.Controls.Add(this.lblMelee0TypeHeader);
            this.tabMelee0.Controls.Add(this.lblMelee0NameHeader);
            this.tabMelee0.Controls.Add(this.txtMelee0Notes);
            this.tabMelee0.Location = new System.Drawing.Point(4, 4);
            this.tabMelee0.Name = "tabMelee0";
            this.tabMelee0.Padding = new System.Windows.Forms.Padding(3);
            this.tabMelee0.Size = new System.Drawing.Size(771, 224);
            this.tabMelee0.TabIndex = 0;
            this.tabMelee0.Text = "New...";
            this.tabMelee0.UseVisualStyleBackColor = true;
            // 
            // comMelee0DamageDie
            // 
            this.comMelee0DamageDie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comMelee0DamageDie.FormattingEnabled = true;
            this.comMelee0DamageDie.Items.AddRange(new object[] {
            "D2",
            "D4",
            "D6",
            "D8",
            "D10",
            "D12",
            "D20"});
            this.comMelee0DamageDie.Location = new System.Drawing.Point(404, 34);
            this.comMelee0DamageDie.Name = "comMelee0DamageDie";
            this.comMelee0DamageDie.Size = new System.Drawing.Size(55, 28);
            this.comMelee0DamageDie.TabIndex = 206;
            // 
            // nudMelee0DmgMod
            // 
            this.nudMelee0DmgMod.Location = new System.Drawing.Point(473, 35);
            this.nudMelee0DmgMod.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMelee0DmgMod.Name = "nudMelee0DmgMod";
            this.nudMelee0DmgMod.Size = new System.Drawing.Size(50, 27);
            this.nudMelee0DmgMod.TabIndex = 238;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(529, 35);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 27);
            this.numericUpDown1.TabIndex = 237;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMelee0AtkMod
            // 
            this.lblMelee0AtkMod.BackColor = System.Drawing.Color.Black;
            this.lblMelee0AtkMod.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMelee0AtkMod.ForeColor = System.Drawing.Color.White;
            this.lblMelee0AtkMod.Location = new System.Drawing.Point(526, 3);
            this.lblMelee0AtkMod.Name = "lblMelee0AtkMod";
            this.lblMelee0AtkMod.Size = new System.Drawing.Size(93, 27);
            this.lblMelee0AtkMod.TabIndex = 236;
            this.lblMelee0AtkMod.Text = "ATK MOD";
            this.lblMelee0AtkMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMelee0DmgRoll
            // 
            this.btnMelee0DmgRoll.Location = new System.Drawing.Point(388, 187);
            this.btnMelee0DmgRoll.Name = "btnMelee0DmgRoll";
            this.btnMelee0DmgRoll.Size = new System.Drawing.Size(163, 31);
            this.btnMelee0DmgRoll.TabIndex = 235;
            this.btnMelee0DmgRoll.Text = "Roll Damage";
            this.btnMelee0DmgRoll.UseVisualStyleBackColor = true;
            // 
            // btnMelee0AtkRoll
            // 
            this.btnMelee0AtkRoll.Location = new System.Drawing.Point(219, 186);
            this.btnMelee0AtkRoll.Name = "btnMelee0AtkRoll";
            this.btnMelee0AtkRoll.Size = new System.Drawing.Size(163, 31);
            this.btnMelee0AtkRoll.TabIndex = 234;
            this.btnMelee0AtkRoll.Text = "Roll Attack";
            this.btnMelee0AtkRoll.UseVisualStyleBackColor = true;
            // 
            // lblMelee0Lbs
            // 
            this.lblMelee0Lbs.AutoSize = true;
            this.lblMelee0Lbs.Location = new System.Drawing.Point(498, 101);
            this.lblMelee0Lbs.Name = "lblMelee0Lbs";
            this.lblMelee0Lbs.Size = new System.Drawing.Size(28, 20);
            this.lblMelee0Lbs.TabIndex = 233;
            this.lblMelee0Lbs.Text = "lbs";
            // 
            // lblMelee0Feet
            // 
            this.lblMelee0Feet.AutoSize = true;
            this.lblMelee0Feet.Location = new System.Drawing.Point(245, 97);
            this.lblMelee0Feet.Name = "lblMelee0Feet";
            this.lblMelee0Feet.Size = new System.Drawing.Size(19, 20);
            this.lblMelee0Feet.TabIndex = 232;
            this.lblMelee0Feet.Text = "ft";
            // 
            // nudMelee0Reach
            // 
            this.nudMelee0Reach.Location = new System.Drawing.Point(137, 92);
            this.nudMelee0Reach.Name = "nudMelee0Reach";
            this.nudMelee0Reach.Size = new System.Drawing.Size(102, 27);
            this.nudMelee0Reach.TabIndex = 231;
            this.nudMelee0Reach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comMelee0Size
            // 
            this.comMelee0Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comMelee0Size.FormattingEnabled = true;
            this.comMelee0Size.Items.AddRange(new object[] {
            "Fine",
            "Diminutive",
            "Tiny",
            "Small",
            "Medium",
            "Large",
            "Huge",
            "Gargantuan",
            "Colossal"});
            this.comMelee0Size.Location = new System.Drawing.Point(7, 92);
            this.comMelee0Size.Name = "comMelee0Size";
            this.comMelee0Size.Size = new System.Drawing.Size(129, 28);
            this.comMelee0Size.TabIndex = 230;
            // 
            // btnMelee0Delete
            // 
            this.btnMelee0Delete.BackColor = System.Drawing.Color.Red;
            this.btnMelee0Delete.Location = new System.Drawing.Point(712, 128);
            this.btnMelee0Delete.Name = "btnMelee0Delete";
            this.btnMelee0Delete.Size = new System.Drawing.Size(46, 46);
            this.btnMelee0Delete.TabIndex = 229;
            this.btnMelee0Delete.Text = "DEL";
            this.btnMelee0Delete.UseVisualStyleBackColor = false;
            // 
            // txtMelee0SpecProp
            // 
            this.txtMelee0SpecProp.Location = new System.Drawing.Point(530, 93);
            this.txtMelee0SpecProp.Name = "txtMelee0SpecProp";
            this.txtMelee0SpecProp.Size = new System.Drawing.Size(232, 27);
            this.txtMelee0SpecProp.TabIndex = 227;
            // 
            // lblMelee0SpecPropHead
            // 
            this.lblMelee0SpecPropHead.BackColor = System.Drawing.Color.Black;
            this.lblMelee0SpecPropHead.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMelee0SpecPropHead.ForeColor = System.Drawing.Color.White;
            this.lblMelee0SpecPropHead.Location = new System.Drawing.Point(530, 63);
            this.lblMelee0SpecPropHead.Name = "lblMelee0SpecPropHead";
            this.lblMelee0SpecPropHead.Size = new System.Drawing.Size(232, 27);
            this.lblMelee0SpecPropHead.TabIndex = 226;
            this.lblMelee0SpecPropHead.Text = "SPECIAL PROPERTIES";
            this.lblMelee0SpecPropHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMelee0Weight
            // 
            this.txtMelee0Weight.Location = new System.Drawing.Point(399, 93);
            this.txtMelee0Weight.Name = "txtMelee0Weight";
            this.txtMelee0Weight.Size = new System.Drawing.Size(101, 27);
            this.txtMelee0Weight.TabIndex = 225;
            // 
            // lblMelee0WeightHeader
            // 
            this.lblMelee0WeightHeader.BackColor = System.Drawing.Color.Black;
            this.lblMelee0WeightHeader.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMelee0WeightHeader.ForeColor = System.Drawing.Color.White;
            this.lblMelee0WeightHeader.Location = new System.Drawing.Point(399, 63);
            this.lblMelee0WeightHeader.Name = "lblMelee0WeightHeader";
            this.lblMelee0WeightHeader.Size = new System.Drawing.Size(130, 27);
            this.lblMelee0WeightHeader.TabIndex = 224;
            this.lblMelee0WeightHeader.Text = "WEIGHT";
            this.lblMelee0WeightHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMelee0Notes
            // 
            this.lblMelee0Notes.BackColor = System.Drawing.Color.Black;
            this.lblMelee0Notes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMelee0Notes.ForeColor = System.Drawing.Color.White;
            this.lblMelee0Notes.Location = new System.Drawing.Point(7, 123);
            this.lblMelee0Notes.Name = "lblMelee0Notes";
            this.lblMelee0Notes.Size = new System.Drawing.Size(699, 27);
            this.lblMelee0Notes.TabIndex = 222;
            this.lblMelee0Notes.Text = "NOTES";
            this.lblMelee0Notes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMelee0Hardness
            // 
            this.txtMelee0Hardness.Location = new System.Drawing.Point(268, 93);
            this.txtMelee0Hardness.Name = "txtMelee0Hardness";
            this.txtMelee0Hardness.Size = new System.Drawing.Size(130, 27);
            this.txtMelee0Hardness.TabIndex = 219;
            // 
            // lblMelee0HardHeader
            // 
            this.lblMelee0HardHeader.BackColor = System.Drawing.Color.Black;
            this.lblMelee0HardHeader.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMelee0HardHeader.ForeColor = System.Drawing.Color.White;
            this.lblMelee0HardHeader.Location = new System.Drawing.Point(268, 63);
            this.lblMelee0HardHeader.Name = "lblMelee0HardHeader";
            this.lblMelee0HardHeader.Size = new System.Drawing.Size(130, 27);
            this.lblMelee0HardHeader.TabIndex = 218;
            this.lblMelee0HardHeader.Text = "HARDNESS";
            this.lblMelee0HardHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMelee0ReachHeader
            // 
            this.lblMelee0ReachHeader.BackColor = System.Drawing.Color.Black;
            this.lblMelee0ReachHeader.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMelee0ReachHeader.ForeColor = System.Drawing.Color.White;
            this.lblMelee0ReachHeader.Location = new System.Drawing.Point(137, 63);
            this.lblMelee0ReachHeader.Name = "lblMelee0ReachHeader";
            this.lblMelee0ReachHeader.Size = new System.Drawing.Size(130, 27);
            this.lblMelee0ReachHeader.TabIndex = 216;
            this.lblMelee0ReachHeader.Text = "REACH";
            this.lblMelee0ReachHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMelee0SizeHeader
            // 
            this.lblMelee0SizeHeader.BackColor = System.Drawing.Color.Black;
            this.lblMelee0SizeHeader.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMelee0SizeHeader.ForeColor = System.Drawing.Color.White;
            this.lblMelee0SizeHeader.Location = new System.Drawing.Point(6, 63);
            this.lblMelee0SizeHeader.Name = "lblMelee0SizeHeader";
            this.lblMelee0SizeHeader.Size = new System.Drawing.Size(130, 27);
            this.lblMelee0SizeHeader.TabIndex = 214;
            this.lblMelee0SizeHeader.Text = "SIZE";
            this.lblMelee0SizeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comMelee0CritMulti
            // 
            this.comMelee0CritMulti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comMelee0CritMulti.FormattingEnabled = true;
            this.comMelee0CritMulti.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.comMelee0CritMulti.Location = new System.Drawing.Point(716, 35);
            this.comMelee0CritMulti.Name = "comMelee0CritMulti";
            this.comMelee0CritMulti.Size = new System.Drawing.Size(46, 28);
            this.comMelee0CritMulti.TabIndex = 213;
            // 
            // comMelee0Crit
            // 
            this.comMelee0Crit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comMelee0Crit.FormattingEnabled = true;
            this.comMelee0Crit.Items.AddRange(new object[] {
            "18",
            "19",
            "20"});
            this.comMelee0Crit.Location = new System.Drawing.Point(622, 34);
            this.comMelee0Crit.Name = "comMelee0Crit";
            this.comMelee0Crit.Size = new System.Drawing.Size(43, 28);
            this.comMelee0Crit.TabIndex = 209;
            // 
            // lblMelee0DmgPlus
            // 
            this.lblMelee0DmgPlus.AutoSize = true;
            this.lblMelee0DmgPlus.Location = new System.Drawing.Point(459, 40);
            this.lblMelee0DmgPlus.Name = "lblMelee0DmgPlus";
            this.lblMelee0DmgPlus.Size = new System.Drawing.Size(19, 20);
            this.lblMelee0DmgPlus.TabIndex = 208;
            this.lblMelee0DmgPlus.Text = "+";
            // 
            // txtMelee0DieCount
            // 
            this.txtMelee0DieCount.Location = new System.Drawing.Point(369, 34);
            this.txtMelee0DieCount.Name = "txtMelee0DieCount";
            this.txtMelee0DieCount.Size = new System.Drawing.Size(30, 27);
            this.txtMelee0DieCount.TabIndex = 204;
            this.txtMelee0DieCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comMelee0Type
            // 
            this.comMelee0Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comMelee0Type.FormattingEnabled = true;
            this.comMelee0Type.Items.AddRange(new object[] {
            "SLASHING",
            "PIERCING",
            "BLUDGEON"});
            this.comMelee0Type.Location = new System.Drawing.Point(243, 33);
            this.comMelee0Type.Name = "comMelee0Type";
            this.comMelee0Type.Size = new System.Drawing.Size(124, 28);
            this.comMelee0Type.TabIndex = 203;
            // 
            // txtMelee0Name
            // 
            this.txtMelee0Name.Location = new System.Drawing.Point(6, 33);
            this.txtMelee0Name.Name = "txtMelee0Name";
            this.txtMelee0Name.Size = new System.Drawing.Size(235, 27);
            this.txtMelee0Name.TabIndex = 202;
            // 
            // lblMelee0CritHeader
            // 
            this.lblMelee0CritHeader.BackColor = System.Drawing.Color.Black;
            this.lblMelee0CritHeader.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMelee0CritHeader.ForeColor = System.Drawing.Color.White;
            this.lblMelee0CritHeader.Location = new System.Drawing.Point(620, 3);
            this.lblMelee0CritHeader.Name = "lblMelee0CritHeader";
            this.lblMelee0CritHeader.Size = new System.Drawing.Size(142, 27);
            this.lblMelee0CritHeader.TabIndex = 201;
            this.lblMelee0CritHeader.Text = "CRITICAL";
            this.lblMelee0CritHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMelee0DmgHeader
            // 
            this.lblMelee0DmgHeader.BackColor = System.Drawing.Color.Black;
            this.lblMelee0DmgHeader.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMelee0DmgHeader.ForeColor = System.Drawing.Color.White;
            this.lblMelee0DmgHeader.Location = new System.Drawing.Point(368, 3);
            this.lblMelee0DmgHeader.Name = "lblMelee0DmgHeader";
            this.lblMelee0DmgHeader.Size = new System.Drawing.Size(157, 27);
            this.lblMelee0DmgHeader.TabIndex = 200;
            this.lblMelee0DmgHeader.Text = "DAMAGE";
            this.lblMelee0DmgHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMelee0TypeHeader
            // 
            this.lblMelee0TypeHeader.BackColor = System.Drawing.Color.Black;
            this.lblMelee0TypeHeader.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMelee0TypeHeader.ForeColor = System.Drawing.Color.White;
            this.lblMelee0TypeHeader.Location = new System.Drawing.Point(242, 3);
            this.lblMelee0TypeHeader.Name = "lblMelee0TypeHeader";
            this.lblMelee0TypeHeader.Size = new System.Drawing.Size(125, 27);
            this.lblMelee0TypeHeader.TabIndex = 199;
            this.lblMelee0TypeHeader.Text = "TYPE";
            this.lblMelee0TypeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMelee0NameHeader
            // 
            this.lblMelee0NameHeader.BackColor = System.Drawing.Color.Black;
            this.lblMelee0NameHeader.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMelee0NameHeader.ForeColor = System.Drawing.Color.White;
            this.lblMelee0NameHeader.Location = new System.Drawing.Point(6, 3);
            this.lblMelee0NameHeader.Name = "lblMelee0NameHeader";
            this.lblMelee0NameHeader.Size = new System.Drawing.Size(235, 27);
            this.lblMelee0NameHeader.TabIndex = 198;
            this.lblMelee0NameHeader.Text = "WEAPON";
            this.lblMelee0NameHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMelee0Notes
            // 
            this.txtMelee0Notes.Location = new System.Drawing.Point(7, 153);
            this.txtMelee0Notes.Name = "txtMelee0Notes";
            this.txtMelee0Notes.Size = new System.Drawing.Size(699, 27);
            this.txtMelee0Notes.TabIndex = 223;
            // 
            // lblMelee0Crit
            // 
            this.lblMelee0Crit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMelee0Crit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblMelee0Crit.Location = new System.Drawing.Point(662, 36);
            this.lblMelee0Crit.Name = "lblMelee0Crit";
            this.lblMelee0Crit.Size = new System.Drawing.Size(57, 25);
            this.lblMelee0Crit.TabIndex = 211;
            this.lblMelee0Crit.Text = "- 20 x";
            this.lblMelee0Crit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panMeleeWeapons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panMeleeWeapons.ResumeLayout(false);
            this.tabMeleeWeapons.ResumeLayout(false);
            this.tabMelee0.ResumeLayout(false);
            this.tabMelee0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMelee0DmgMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMelee0Reach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panMeleeWeapons;
        private Button btnNewMeleeWeapon;
        private TabControl tabMeleeWeapons;
        private TabPage tabMelee0;
        private TextBox txtMelee0Weight;
        private ComboBox comMelee0DamageDie;
        private Label lblMelee0CritHeader;
        private Label lblMelee0Crit;
        private NumericUpDown nudMelee0DmgMod;
        private ComboBox comMelee0Crit;
        private NumericUpDown numericUpDown1;
        private ComboBox comMelee0CritMulti;
        private Button btnMelee0DmgRoll;
        private Button btnMelee0AtkRoll;
        private Label lblMelee0AtkMod;
        private Label lblMelee0Lbs;
        private Label lblMelee0Feet;
        private NumericUpDown nudMelee0Reach;
        private ComboBox comMelee0Size;
        private Button btnMelee0Delete;
        private TextBox txtMelee0SpecProp;
        private Label lblMelee0SpecPropHead;
        private Label lblMelee0WeightHeader;
        private Label lblMelee0Notes;
        private TextBox txtMelee0Hardness;
        private Label lblMelee0HardHeader;
        private Label lblMelee0ReachHeader;
        private Label lblMelee0SizeHeader;
        private Label lblMelee0DmgPlus;
        private TextBox txtMelee0DieCount;
        private ComboBox comMelee0Type;
        private TextBox txtMelee0Name;
        private Label lblMelee0DmgHeader;
        private Label lblMelee0TypeHeader;
        private Label lblMelee0NameHeader;
        private TextBox txtMelee0Notes;
    }
}