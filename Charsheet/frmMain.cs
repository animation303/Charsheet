using System.Linq;

namespace Charsheet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private static int calcMod(double attrValue)
        {
            double e;
            e = Math.Floor((attrValue - 10) / 2);
            return Convert.ToInt32(e);
            //return Convert.ToInt32(Math.Floor((attrValue - 10) / 2));
        }
        #region Roll functions
        private static int rollHitDice(int sides, int modifier = 0)
        {
            var frm = new frmMain();
            _ = Convert.ToInt32(frm.txtHP.Text);
            Random z = new(Guid.NewGuid().GetHashCode());
            int hp = z.Next(1, sides) + modifier;
            if (hp == 0) { hp += 1; } // rolled hp cant be zero, even after modifier, so return at least 1
            MessageBox.Show("You gained " + Convert.ToString(hp) + " hp.", "Level Up!", MessageBoxButtons.OK);
            return hp;
        }
        private static int rollDice(int sides, int quantity = 1, int modifier = 0, int abilityMod = 0, string rollType = "Generic Roll")
        {
            Random dice = new(Guid.NewGuid().GetHashCode());
            int[] z = new int[quantity];
            List<int> theDie = new();
            theDie.AddRange(from int i in z
                            select dice.Next(1, sides));
            int y = theDie.Count;
            string testresult;
            int totalresult = 0;
            // MessageBox.Show(Convert.ToString(y));
            if (y > 1)
                {
                    string b = "";
                    for (int ctr = 0; ctr < theDie.Count; ctr++)
                        {
                            b += Convert.ToString(theDie[ctr]) + " ";
                            totalresult += theDie[ctr];
                        }
/*                    foreach (int i in theDie)
                        {
                            b += Convert.ToString(theDie[i]) + " ";
                            totalresult = +i;
                        }
*/
                
                testresult = "Rolls ( " + b + " = " + totalresult + " ) + Modifier ( " + Convert.ToString(modifier);
                totalresult += modifier;
                if (abilityMod != 0) { 
                    totalresult += abilityMod;
                    testresult += " ) + Ability Mod ( " + Convert.ToString(abilityMod);
                }
                testresult += " ) = " + Convert.ToString(totalresult);
                MessageBox.Show(testresult, rollType, MessageBoxButtons.OK);
                }
            else
                {
                totalresult = theDie[0] + modifier;
                if (abilityMod != 0) { totalresult += abilityMod; }
                testresult = "Roll ( " + Convert.ToString(theDie[0]) + " ) + Modifier ( " + Convert.ToString(modifier);
                if (abilityMod != 0) { testresult += " + Ability Mod ( " + Convert.ToString(abilityMod); };
                testresult+= " ) = " + totalresult;                    
                
                MessageBox.Show(testresult, rollType, MessageBoxButtons.OK);
                }
            return totalresult;
        }
        #endregion
        private void frmMain_Load(object sender, EventArgs e)
        {
            comHitDie.SelectedIndex = 0;
        }
        private static int calcSave(string type)
        {
            switch (type)
            {
                case "fort":
                    break;
                case "reflex":
                    break;
                case "willpower":
                    break;
            }
            return 0;
        }
        private void btnRollHD_Click(object sender, EventArgs e)
        {
            string s = comHitDie.Text;
            int mod;
            int q = Convert.ToInt32(txtHP.Text);
            int die = Convert.ToInt32(s.Remove(0, 1));
            if (nudConTemp.Value == nudCon.Value)
            {
                mod = Convert.ToInt32(txtConMod.Text);
            }
                else
            {
                mod = Convert.ToInt32(txtConModTemp.Text);
            }
            int newhp = rollHitDice(die, mod) + q;
            txtHP.Text = Convert.ToString(newhp);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string w1 = comMelee0DamageDie.Text;
            int w = Convert.ToInt32(w1.Remove(0, 1));
            int x = Convert.ToInt32(txtMelee0DieCount.Text);
            int y = Convert.ToInt32(nudMelee0DmgMod.Value);
            int z = Convert.ToInt32(txtStrMod.Text);
            _ = rollDice(w, x, y, z, "Melee Attack");
        }

        #region attributes

        //
        // Strength
        //
        private void nudStr_ValueChanged(object sender, EventArgs e)
        {
            txtStrMod.Text = Convert.ToString(calcMod(Convert.ToDouble(nudStr.Value)));
            nudStrTemp.Value = nudStr.Value;
        }
        private void nudStrTemp_ValueChanged(object sender, EventArgs e)
        {
            txtStrModTemp.Text = Convert.ToString(calcMod(Convert.ToDouble(nudStrTemp.Value)));
            decimal v = nudStr.Value;
            decimal x = nudStrTemp.Value;
            switch (x)
            {
                case decimal when x < v:
                    nudStrTemp.ForeColor = Color.Red;
                    break;
                case decimal when x > v:
                    nudStrTemp.ForeColor = Color.Green;
                    break;
                case decimal when x == v:
                    nudStrTemp.ForeColor = Color.Black;
                    break;
            }
        }
        private void btnStrCheck_Click(object sender, EventArgs e)
        {
            if (nudStrTemp.Value == nudStr.Value) // check for modified attribute
            {
                int z = Convert.ToInt32(txtStrMod.Text);
                rollDice(20, 1, z, 0, "Strength Check");
            }
            else
            {
                int z = Convert.ToInt32(txtStrModTemp.Text);
                rollDice(20, 1, z, 0, "Strength Check (Modified)");
            }
        }

        //
        // Dexterity
        //
        private void nudDex_ValueChanged(object sender, EventArgs e)
        {
            txtDexMod.Text = Convert.ToString(calcMod(Convert.ToDouble(nudDex.Value)));
            nudDexTemp.Value = nudDex.Value;
            
            txtReflexAbilMod.Text = txtDexMod.Text;
            txtACAbilityMod.Text = txtDexMod.Text;
            txtInitAbilMod.Text = txtDexMod.Text;
        }
        private void nudDexTemp_ValueChanged(object sender, EventArgs e)
        {
            txtDexModTemp.Text = Convert.ToString(calcMod(Convert.ToDouble(nudDexTemp.Value)));
            
            txtReflexAbilMod.Text = txtDexModTemp.Text;
            txtACAbilityMod.Text = txtDexModTemp.Text;
            txtInitAbilMod.Text = txtDexModTemp.Text;

            decimal v = nudDex.Value;
            decimal x = nudDexTemp.Value;
            switch (x)
            {
                case decimal when x < v:
                    nudDexTemp.ForeColor = Color.Red;
                    break;
                case decimal when x > v:
                    nudDexTemp.ForeColor = Color.Green;
                    break;
                case decimal when x == v:
                    nudDexTemp.ForeColor = Color.Black;
                    break;
            }
        }
        private void btnDexCheck_Click(object sender, EventArgs e)
        {
            if (nudDexTemp.Value == nudDex.Value) // check for modified attribute
            {
                int z = Convert.ToInt32(txtDexMod.Text);
                rollDice(20, 1, z, 0, "Dexterity Check");
            }
            else
            {
                int z = Convert.ToInt32(txtDexModTemp.Text);
                rollDice(20, 1, z, 0, "Dexterity Check (Modified)");
            }
        }

        //
        // Constitution
        //

        private void nudCon_ValueChanged(object sender, EventArgs e)
        {
            txtConMod.Text = Convert.ToString(calcMod(Convert.ToDouble(nudCon.Value)));
            nudConTemp.Value = nudCon.Value;
            
            txtFortAbilMod.Text = txtConMod.Text;
        }
        private void nudConTemp_ValueChanged(object sender, EventArgs e)
        {
            txtConModTemp.Text = Convert.ToString(calcMod(Convert.ToDouble(nudConTemp.Value)));
            txtFortAbilMod.Text = txtConModTemp.Text;
            
            decimal v = nudCon.Value;
            decimal x = nudConTemp.Value;
            switch (x)
            {
                case decimal when x < v:
                    nudConTemp.ForeColor = Color.Red;
                    break;
                case decimal when x > v:
                    nudConTemp.ForeColor = Color.Green;
                    break;
                case decimal when x == v:
                    nudConTemp.ForeColor = Color.Black;
                    break;
            }
        }
        private void btnConCheck_Click(object sender, EventArgs e)
        {
            if (nudConTemp.Value == nudCon.Value) // check for modified attribute
            {
                int z = Convert.ToInt32(txtConMod.Text);
                rollDice(20, 1, z, 0, "Constitution Check");
            }
            else
            {
                int z = Convert.ToInt32(txtConModTemp.Text);
                rollDice(20, 1, z, 0, "Constitution Check (Modified)");
            }
        }

        //
        // Intelligence
        //

        private void nudInt_ValueChanged(object sender, EventArgs e)
        {
            txtIntMod.Text = Convert.ToString(calcMod(Convert.ToDouble(nudInt.Value)));
            nudIntTemp.Value = nudInt.Value;
        }
        private void nudIntTemp_ValueChanged(object sender, EventArgs e)
        {
            txtIntModTemp.Text = Convert.ToString(calcMod(Convert.ToDouble(nudIntTemp.Value)));
            decimal v = nudInt.Value;
            decimal x = nudIntTemp.Value;
            switch (x)
            {
                case decimal when x < v:
                    nudIntTemp.ForeColor = Color.Red;
                    break;
                case decimal when x > v:
                    nudIntTemp.ForeColor = Color.Green;
                    break;
                case decimal when x == v:
                    nudIntTemp.ForeColor = Color.Black;
                    break;
            }
        }
        private void btnIntCheck_Click(object sender, EventArgs e)
        {
            if (nudIntTemp.Value == nudInt.Value) // check for modified attribute
            {
                int z = Convert.ToInt32(txtIntMod.Text);
                rollDice(20, 1, z, 0, "Intelligence Check");
            }
            else
            {
                int z = Convert.ToInt32(txtIntModTemp.Text);
                rollDice(20, 1, z, 0, "Intelligence Check (Modified)");
            }
        }

        //
        // Wisdom
        //

        private void nudWis_ValueChanged(object sender, EventArgs e)
        {
            txtWisMod.Text = Convert.ToString(calcMod(Convert.ToDouble(nudWis.Value)));
            nudWisTemp.Value = nudWis.Value;
        
            txtWillAbilMod.Text = txtWisMod.Text;
        }
        private void nudWisTemp_ValueChanged(object sender, EventArgs e)
        {
            txtWisModTemp.Text = Convert.ToString(calcMod(Convert.ToDouble(nudWisTemp.Value)));
            decimal v = nudWis.Value;
            decimal x = nudWisTemp.Value;
            
            txtWillAbilMod.Text = txtWisModTemp.Text;
            switch (x)
            {
                case decimal when x < v:
                    nudWisTemp.ForeColor = Color.Red;
                    break;
                case decimal when x > v:
                    nudWisTemp.ForeColor = Color.Green;
                    break;
                case decimal when x == v:
                    nudWisTemp.ForeColor = Color.Black;
                    break;
            }
        }
        private void btnWisCheck_Click(object sender, EventArgs e)
        {
            if (nudWisTemp.Value == nudWis.Value) // check for modified attribute
            {
                int z = Convert.ToInt32(txtWisMod.Text);
                rollDice(20, 1, z, 0, "Wisdom Check");
            }
            else
            {
                int z = Convert.ToInt32(txtWisModTemp.Text);
                rollDice(20, 1, z, 0, "Wisdom Check (Modified)");
            }
        }

        //
        // Charisma
        //
        private void nudCha_ValueChanged(object sender, EventArgs e)
        {
            txtChaMod.Text = Convert.ToString(calcMod(Convert.ToDouble(nudCha.Value)));
            nudChaTemp.Value = nudCha.Value;
        }
        private void nudChaTemp_ValueChanged(object sender, EventArgs e)
        {
            txtChaModTemp.Text = Convert.ToString(calcMod(Convert.ToDouble(nudChaTemp.Value)));
            decimal v = nudCha.Value;
            decimal x = nudChaTemp.Value;
            switch (x)
            {
                case decimal when x < v:
                    nudChaTemp.ForeColor = Color.Red;
                    break;
                case decimal when x > v:
                    nudChaTemp.ForeColor = Color.Green;
                    break;
                case decimal when x == v:
                    nudChaTemp.ForeColor = Color.Black;
                    break;
            }
        }
        private void btnChaCheck_Click(object sender, EventArgs e)
        {
            if (nudChaTemp.Value == nudCha.Value) // check for modified attribute
            {
                int z = Convert.ToInt32(txtChaMod.Text);
                rollDice(20, 1, z, 0, "Charisma Check");
            }
            else
            {
                int z = Convert.ToInt32(txtChaModTemp.Text);
                rollDice(20, 1, z, 0, "Charisma Check (Modified)");
            }
        }
        #endregion
        #region fort/reflex/will
        //
        // Fortitude
        //

        private void txtFortBase_TextChanged(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(txtFortBase.Text) +
                    Convert.ToInt32(txtFortAbilMod.Text) +
                    Convert.ToInt32(txtFortMagicMod.Text) +
                    Convert.ToInt32(txtFortMiscMod.Text) +
                    Convert.ToInt32(txtFortTempMod.Text);
            txtFort.Text = Convert.ToString(r);

        }
        private void txtFortAbilMod_TextChanged(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(txtFortBase.Text) +
                    Convert.ToInt32(txtFortAbilMod.Text) +
                    Convert.ToInt32(txtFortMagicMod.Text) +
                    Convert.ToInt32(txtFortMiscMod.Text) +
                    Convert.ToInt32(txtFortTempMod.Text);
            txtFort.Text = Convert.ToString(r);
        }
        private void txtFortMagicMod_TextChanged(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(txtFortBase.Text) +
                    Convert.ToInt32(txtFortAbilMod.Text) +
                    Convert.ToInt32(txtFortMagicMod.Text) +
                    Convert.ToInt32(txtFortMiscMod.Text) +
                    Convert.ToInt32(txtFortTempMod.Text);
            txtFort.Text = Convert.ToString(r);
        }
        private void txtFortMiscMod_TextChanged(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(txtFortBase.Text) +
                    Convert.ToInt32(txtFortAbilMod.Text) +
                    Convert.ToInt32(txtFortMagicMod.Text) +
                    Convert.ToInt32(txtFortMiscMod.Text) +
                    Convert.ToInt32(txtFortTempMod.Text);
            txtFort.Text = Convert.ToString(r);
        }
        private void txtFortTempMod_TextChanged(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(txtFortBase.Text) +
                    Convert.ToInt32(txtFortAbilMod.Text) +
                    Convert.ToInt32(txtFortMagicMod.Text) +
                    Convert.ToInt32(txtFortMiscMod.Text) +
                    Convert.ToInt32(txtFortTempMod.Text);
            txtFort.Text = Convert.ToString(r);
        }
        private void tmrCheckAttr_Tick(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(txtFortBase.Text) +
                    Convert.ToInt32(txtFortAbilMod.Text) +
                    Convert.ToInt32(txtFortMagicMod.Text) +
                    Convert.ToInt32(txtFortMiscMod.Text) +
                    Convert.ToInt32(txtFortTempMod.Text);
            txtFort.Text = Convert.ToString(r);

            int s = Convert.ToInt32(txtReflexBase.Text) +
                    Convert.ToInt32(txtReflexAbilMod.Text) +
                    Convert.ToInt32(txtReflexMagicMod.Text) +
                    Convert.ToInt32(txtReflexMiscMod.Text) +
                    Convert.ToInt32(txtReflexTempMod.Text);
            txtReflex.Text = Convert.ToString(s);

            int t = Convert.ToInt32(txtWillBase.Text) +
                Convert.ToInt32(txtWillAbilMod.Text) +
                Convert.ToInt32(txtWillMagicMod.Text) +
                Convert.ToInt32(txtWillMiscMod.Text) +
                Convert.ToInt32(txtWillTempMod.Text);
            txtWill.Text = Convert.ToString(t);
        }
        private void btnFortCheck_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(txtFort.Text);
            rollDice(20, 1, d, 0, "Fortitude Check!");
        }

        //
        // Reflex
        //
        private void txtReflexBase_TextChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtReflexBase.Text) +
                    Convert.ToInt32(txtReflexAbilMod.Text) +
                    Convert.ToInt32(txtReflexMagicMod.Text) +
                    Convert.ToInt32(txtReflexMiscMod.Text) +
                    Convert.ToInt32(txtReflexTempMod.Text);
            txtReflex.Text = Convert.ToString(s);
        }
        private void txtReflexAbilMod_TextChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtReflexBase.Text) +
                    Convert.ToInt32(txtReflexAbilMod.Text) +
                    Convert.ToInt32(txtReflexMagicMod.Text) +
                    Convert.ToInt32(txtReflexMiscMod.Text) +
                    Convert.ToInt32(txtReflexTempMod.Text);
            txtReflex.Text = Convert.ToString(s);
        }
        private void txtReflexMagicMod_TextChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtReflexBase.Text) +
                    Convert.ToInt32(txtReflexAbilMod.Text) +
                    Convert.ToInt32(txtReflexMagicMod.Text) +
                    Convert.ToInt32(txtReflexMiscMod.Text) +
                    Convert.ToInt32(txtReflexTempMod.Text);
            txtReflex.Text = Convert.ToString(s);
        }
        private void txtReflexMiscMod_TextChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtReflexBase.Text) +
                    Convert.ToInt32(txtReflexAbilMod.Text) +
                    Convert.ToInt32(txtReflexMagicMod.Text) +
                    Convert.ToInt32(txtReflexMiscMod.Text) +
                    Convert.ToInt32(txtReflexTempMod.Text);
            txtReflex.Text = Convert.ToString(s);
        }
        private void txtReflexTempMod_TextChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtReflexBase.Text) +
                    Convert.ToInt32(txtReflexAbilMod.Text) +
                    Convert.ToInt32(txtReflexMagicMod.Text) +
                    Convert.ToInt32(txtReflexMiscMod.Text) +
                    Convert.ToInt32(txtReflexTempMod.Text);
            txtReflex.Text = Convert.ToString(s);
        }
        private void btnReflexCheck_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(txtReflex.Text);
            rollDice(20, 1, d, 0, "Reflex Check!");
        }

        //
        // Willpower
        //
        private void txtWillBase_TextChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtWillBase.Text) +
                    Convert.ToInt32(txtWillAbilMod.Text) +
                    Convert.ToInt32(txtWillMagicMod.Text) +
                    Convert.ToInt32(txtWillMiscMod.Text) +
                    Convert.ToInt32(txtWillTempMod.Text);
            txtWill.Text = Convert.ToString(s);
        }
        private void txtWillAbilMod_TextChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtWillBase.Text) +
                    Convert.ToInt32(txtWillAbilMod.Text) +
                    Convert.ToInt32(txtWillMagicMod.Text) +
                    Convert.ToInt32(txtWillMiscMod.Text) +
                    Convert.ToInt32(txtWillTempMod.Text);
            txtWill.Text = Convert.ToString(s);
        }
        private void txtWillMagicMod_TextChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtWillBase.Text) +
                    Convert.ToInt32(txtWillAbilMod.Text) +
                    Convert.ToInt32(txtWillMagicMod.Text) +
                    Convert.ToInt32(txtWillMiscMod.Text) +
                    Convert.ToInt32(txtWillTempMod.Text);
            txtWill.Text = Convert.ToString(s);
        }
        private void txtWillMiscMod_TextChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtWillBase.Text) +
                    Convert.ToInt32(txtWillAbilMod.Text) +
                    Convert.ToInt32(txtWillMagicMod.Text) +
                    Convert.ToInt32(txtWillMiscMod.Text) +
                    Convert.ToInt32(txtWillTempMod.Text);
            txtWill.Text = Convert.ToString(s);
        }
        private void txtWillTempMod_TextChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtWillBase.Text) +
                    Convert.ToInt32(txtWillAbilMod.Text) +
                    Convert.ToInt32(txtWillMagicMod.Text) +
                    Convert.ToInt32(txtWillMiscMod.Text) +
                    Convert.ToInt32(txtWillTempMod.Text);
            txtWill.Text = Convert.ToString(s);
        }
        private void btnWillCheck_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(txtWill.Text);
            rollDice(20, 1, d, 0, "Will Check!");
        }


        #endregion

        #region AC
        private void txtACArmor_TextChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtWillBase.Text)
                + Convert.ToInt32(txtWillAbilMod.Text)
                + Convert.ToInt32(txtWillMagicMod.Text)
                + Convert.ToInt32(txtWillMiscMod.Text)
                + Convert.ToInt32(txtWillTempMod.Text);
            txtWill.Text = Convert.ToString(s);
        }
        private void txtACShield_TextChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtACArmor.Text)
                + Convert.ToInt32(txtACShield.Text)
                + Convert.ToInt32(txtACAbilityMod.Text)
                + Convert.ToInt32(txtACNatArmor.Text)
                + Convert.ToInt32(txtACMiscMod.Text);
            txtAC.Text = Convert.ToString(s);
        }

        private void txtACAbilityMod_TextChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtACArmor.Text)
                + Convert.ToInt32(txtACShield.Text)
                + Convert.ToInt32(txtACAbilityMod.Text)
                + Convert.ToInt32(txtACNatArmor.Text)
                + Convert.ToInt32(txtACMiscMod.Text);
            txtAC.Text = Convert.ToString(s);
        }

        private void txtACNatArmor_TextChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtACArmor.Text)
                + Convert.ToInt32(txtACShield.Text)
                + Convert.ToInt32(txtACAbilityMod.Text)
                + Convert.ToInt32(txtACNatArmor.Text)
                + Convert.ToInt32(txtACMiscMod.Text);
            txtAC.Text = Convert.ToString(s);
        }

        private void txtACMiscMod_TextChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtACArmor.Text)
                + Convert.ToInt32(txtACShield.Text)
                + Convert.ToInt32(txtACAbilityMod.Text)
                + Convert.ToInt32(txtACNatArmor.Text)
                + Convert.ToInt32(txtACMiscMod.Text);
            txtAC.Text = Convert.ToString(s);
        }
        #endregion
        
        private void txtInitAbilMod_TextChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtInitAbilMod.Text) +
                    Convert.ToInt32(txtInitMiscMod.Text);
            txtInit.Text = Convert.ToString(s);
        }

        private void btnRollInit_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(txtInit.Text);
            rollDice(20, 1, d, 0, "Hostile intent is evident, Prepare for battle!");
        }

        private void btnMelee0Delete_Click(object sender, EventArgs e)
        {
            tabMeleeWeapons.TabPages.Remove(tabMeleeWeapons.SelectedTab);
        }

        private void drawHeader(string id, string text, int locx, int locy, string name)
        {

        }
        private void btnNewMeleeWeapon_Click(object sender, EventArgs e)
        {
            // Generate Random Melee Weapon ID
            Random dice = new(Guid.NewGuid().GetHashCode());
            string tty = dice.Next(100000, 999999).ToString();
            string newMeleeID = "Melee" + tty;

            // Create tabpage for melee weapon
            TabPage newMeleeWeapon = new(newMeleeID);
            newMeleeWeapon.Text = "New weapon";
            tabMeleeWeapons.TabPages.Add(newMeleeWeapon);

            #region Weapon Name
            // header
            Label a = new();
            a.Name = "lbl" + newMeleeID + "NameHeader";
            a.Text = "WEAPON NAME";
            a.Location = new Point(6, 3);
            a.Size = new Size(235, 27);
            a.TextAlign = ContentAlignment.MiddleCenter;
            a.Font = new Font("Segoe UI", 10.2f, FontStyle.Bold);
            a.ForeColor = Color.White;
            a.BackColor = Color.Black;
            newMeleeWeapon.Controls.Add(a);
            // control
            TextBox b = new(); 
            b.Name = "txt" + newMeleeID + "Name";
            b.Text = "Melee Weapon " + newMeleeID;
            b.Location = new Point(6, 33);
            b.Size = new Size(235, 27);
            newMeleeWeapon.Controls.Add(b);

            #endregion
            #region damage type
            //header
            Label c = new();
            c.Name = "lbl" + newMeleeID + "TypeHeader";
            c.Text = "TYPE";
            c.Location = new Point(242, 3);
            c.Size = new Size(125, 27);
            c.TextAlign = ContentAlignment.MiddleCenter;
            c.Font = new Font("Segoe UI", 10.2f, FontStyle.Bold);
            c.ForeColor = Color.White;
            c.BackColor = Color.Black;
            newMeleeWeapon.Controls.Add(c);
            //control
            ComboBox d = new ComboBox();
            d.Name = "com" + newMeleeID + "Type";
            d.Location = new Point(243, 33);
            d.Size = new Size(124, 28);
            d.Items.AddRange(new object[] {
            "slashing",
            "piercing",
            "bludgeoning"});
            d.SelectedIndex = 0;
            newMeleeWeapon.Controls.Add(d);
            #endregion

            #region damage
            //header
            Label f = new();
            f.Name = "lbl" + newMeleeID + "DmgHeader";
            f.Text = "DAMAGE";
            f.Location = new Point(368, 3);
            f.Size = new Size(157, 27);
            f.TextAlign = ContentAlignment.MiddleCenter;
            f.Font = new Font("Segoe UI", 10.2f, FontStyle.Bold);
            f.ForeColor = Color.White;
            f.BackColor = Color.Black;
            newMeleeWeapon.Controls.Add(f);
            //controls
            TextBox g = new();
            g.Name = "txt" + newMeleeID + "DieCount";
            g.Text = "1";
            g.Location = new Point(369, 34);
            g.Size = new Size(30, 27);
            g.TextAlign = HorizontalAlignment.Right;
            newMeleeWeapon.Controls.Add(g);
            ComboBox h = new();
            string hh = "com" + newMeleeID + "DamageDie";
            h.Name = hh;
            h.Location = new Point(404, 34);
            h.Size = new Size(55, 28);
            h.Items.AddRange(new object[] {
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20"});
            h.SelectedIndex = 0;
            newMeleeWeapon.Controls.Add(h);
            Label i = new();
            i.Name = "lbl" + newMeleeID + "DmgPlus";
            i.Text = "+";
            i.Location = new Point(456, 37);
            i.Size = new Size(19,20);
            i.TextAlign = ContentAlignment.MiddleCenter;
            newMeleeWeapon.Controls.Add(i);
            NumericUpDown j = new();
            j.Name = "txt" + newMeleeID + "DmgMod";
            j.Text = "0";
            j.Location = new Point(473, 35);
            j.Size = new Size(50, 27);
            j.Value = 0;
            j.Minimum = -100;
            newMeleeWeapon.Controls.Add(j);
            #endregion

        }
    }
}