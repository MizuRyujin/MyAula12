using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        // Property
        private bool ascend;

        // Constructor
        public CompareByName(bool minMax)
        {
            ascend = minMax;
        }


        public int Compare(Player x, Player y)
        {
            if (x == y) return 0;
            if (x == null) return 1;
            if (y == null) return -1;
            if (ascend) return x.Name.CompareTo(y.Name);
            return y.Name.CompareTo(x.Name);
        }
    }
}
