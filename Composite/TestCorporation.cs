using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class TestCorporation
    {
        private Corporation corporation;
        public TestCorporation()
        {
            corporation = new Corporation();
            Division rnd = new Division("R&D");
            rnd.Add(new VP("Hank", "R&D"));
            rnd.Add(new VP("Tony", "R&D"));
            rnd.Add(new VP("Bruce", "R&D"));
            Division battle = new Division("battle");
            battle.Add(new VP("Wanda", "battle"));
            battle.Add(new VP("Pietro", "battle"));
            battle.Add(new VP("Vision", "battle"));
            battle.Add(new VP("Steve", "battle"));
            Division agent = new Division("agent");
            agent.Add(new VP("Natasha", "agent"));
            agent.Add(new VP("Maria", "agent"));
            battle.Add(agent);
            VP vp = new VP("Nick", "SHIELD");
            corporation.Add(rnd);
            corporation.Add(battle);
            corporation.Add(vp);
            corporation.print();
        }
        static void Main(string[] args)
        {
            TestCorporation t = new TestCorporation();
        }
    }
}
