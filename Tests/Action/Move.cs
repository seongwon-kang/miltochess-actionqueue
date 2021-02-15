namespace Tests {
    public class Move : IActionItem
    {
        Unit target;
        int x;
        int y;
        public void SetTarget(Unit unit, int x, int y) {
            target = unit;
            this.x = x;
            this.y = y;
        }

        public string use()
        {
            target.x = x;
            target.y = y;
            return "Move:" + x + "," + y;
        }
    }
}