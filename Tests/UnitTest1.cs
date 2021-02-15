using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            ActionQueue queue = new ActionQueue();

            Unit unit1 = new Unit();
            Unit unit2 = new Unit();

            queue.Add(unit1.moveTo(1,1));
            queue.Add(unit1.attack(unit2));
            
            queue.Add(unit2.moveTo(1,2));
            queue.Add(unit2.attack(unit1));

            var iter = queue.run();

            // # iter 1: unit1 moves to 1,1
            iter.MoveNext();

            Assert.AreEqual("Move:1,1", iter.Current);
            Assert.True(unit1.IsAt(1,1));

            // # iter 2: unit1 attacks
            iter.MoveNext();
            
            Assert.AreEqual("Attack", iter.Current);

            // # iter 3: unit2 moves to 1,1
            iter.MoveNext();

            Assert.AreEqual("Move:1,2", iter.Current);
            Assert.True(unit2.IsAt(1,2));

            // # iter 4: unit2 attacks
            iter.MoveNext();
            
            Assert.AreEqual("Attack", iter.Current);
        }
    }
}