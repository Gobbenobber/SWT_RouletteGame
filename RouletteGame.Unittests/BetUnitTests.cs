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

        [Test]
        public void FieldBetWonAmount_BetOnCorrectField_ReturnAmountIsCorrect()
        {
            var uut = new FieldBet("Jonas", 500, 12);
            var fakeFieldNr12 = new FakeField {Number = 12};
            Assert.That(uut.WonAmount(fakeFieldNr12), Is.EqualTo(36 * 500));
        }

        [Test]
        public void FieldBetWonAmount_BetOnWrongField_ReturnAmountIsCorrect()
        {
            var uut = new FieldBet("Jonas", 500, 12);
            var fakeFieldNr12 = new FakeField { Number = 11 };
            Assert.That(uut.WonAmount(fakeFieldNr12), Is.EqualTo(0));
        }

        [Test]
        public void FieldBetToString_FormatIsCorrect()
        {
            var uut = new FieldBet("Jonas", 500, 12);
            Assert.That(uut.ToString(), Is.EqualTo($"500$ field bet on 12"));
        }
    }

    internal class FakeField : IField
    {
        public uint Number { get; set; }

        public uint Color { get; set; }

        public bool Even { get; set; }
    }
}
