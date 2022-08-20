using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charsheet.DiceRolls
{
    public static class Dice
    {
        public static int calcMod(double attrValue)
        {
            double e;
            e = Math.Floor((attrValue - 10) / 2);
            return Convert.ToInt32(e);
        }

        public static int randomizer9000()
        {
            Random dice = new(Guid.NewGuid().GetHashCode());
            int tty = dice.Next(0, 2147483646);
            return tty;
        }
    }
}
