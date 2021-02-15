using System;

namespace Tests
{
    public class Attack : IActionItem
    {
        Unit Src;
        Unit Dst;

        internal void SetTarget(Unit unit1, Unit unit2)
        {
            Src = unit1;
            Dst = unit2;
        }

        public string use()
        {
            return "Attack";
        }
    }

}