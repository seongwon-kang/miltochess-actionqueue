using System;
using System.Collections.Generic;

namespace Tests
{
    public class Unit
    {
        public int x;
        public int y;

        IActionItem Attack;
        List<IActionItem> Skills;

        internal IActionItem moveTo(int v1, int v2)
        {
            Move move = new Move();
            move.SetTarget(this, v1, v2);

            return move;
        }

        internal IActionItem attack(Unit unit)
        {
            Attack attack = new Attack();
            attack.SetTarget(this, unit);

            return attack;
        }

        public bool IsAt(int x, int y) { return this.x == x && this.y == y; }
    }

}