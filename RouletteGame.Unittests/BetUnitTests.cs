using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RouletteGame.Legacy;

namespace RouletteGame.Unittests
{
    [TestFixture]
    public class BetUnitTests
    {
        [Test]
        public void FieldBetConstructor_InputArguments_ObjectFieldsMatchArguments()
        {
            var uut = new FieldBet("Jonas", 500, 12);

            Assert.That(uut.PlayerName, Is.EqualTo("Jonas"));
            Assert.That(uut.Amount, Is.EqualTo(500));
        }
    }
}
