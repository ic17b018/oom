using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task4
{
    public class Tests
    {
        public void SimpleTest()
        {
            Assert.IsTrue(1 == 1);
        }
        public void QuarterbackTest()
        {
            var x = new QuarterBack("Eli Manning", "New York Giants", 10, 2800);

            Assert.IsTrue(x.Qb_name == "Eli Manning");
            Assert.IsTrue(x.QB_franchise == "New York Giants");
        }
        public void RunningBackTest()
        {
            var y = new RunningBack("Gustav Gans", "Toten Hosen", 40, 2, 30);

            Assert.IsTrue(y.Rb_name == "Gustav Gans");
            Assert.IsTrue(y.Rb_franchise == "Toten Hosen");
        }
        public void CanCreateSum()
        {
            var z = new RunningBack("Kurt Krömer", "Turku Beaver Hunters", 20, 20, 30);

            Assert.IsTrue(z.Rb_purp_yards == 20 + 20 + 30);

        }
    }
}
