using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RouletteGame.Legacy;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework.Constraints;

namespace RouletteGame.Unittests
{
    [TestFixture]
    public class FieldUnitTests
    {
        [Test]
        public void FieldConstructor_InputArguments_ObjectFieldsMatchArguments()
        {
            var uut = new Field(20, 2);
            Assert.That(uut.Color, Is.EqualTo(2));
            Assert.That(uut.Number, Is.EqualTo(20));
        }

        [Test]
        public void FieldConstructor_InputArguments_ObjectColorFieldExceptionThrown()
        {
            Field uut;
            var ex = Assert.Catch<FieldException>(() => uut = new Field(20,3));
            Assert.That(ex.Message, Is.EqualTo("Color 3 not a valid color. Must be either Red or Black"));
        }

        [Test]
        public void FieldConstructor_InputArguments_ObjectNumberFieldExceptionThrown()
        {
            Field uut;
            var ex = Assert.Catch<FieldException>(() => uut = new Field(37, 2));
            StringAssert.Contains("Number 37 not a valid field number", ex.Message);
        }

        [Test]
        public void FieldEven_InputArguments_ObjectEvenIsTrue()
        {
            var uut = new Field(20, 2);
            Assert.That(uut.Even, Is.EqualTo(true));
        }

        [Test]
        public void FieldEven_InputArguments_ObjectEvenIsFalse()
        {
            var uut = new Field(19, 2);
            Assert.That(uut.Even, Is.EqualTo(false));
        }
        [Test]
        public void FieldToString_InputArguments_ExpectReturns19AndColorIsRed()
        {
            var uut = new Field(19, 0);
            Assert.That(uut.ToString(), Is.EqualTo("[19, red]"));
        }

        [Test]
        public void FieldToString_InputArguments_ExpectReturns31AndColorIsBlack()
        {
            var uut = new Field(31, 1);
            Assert.That(uut.ToString(), Is.EqualTo("[31, black]"));
        }

        [Test]
        public void FieldToString_InputArguments_ExpectReturns0AndColorIsGreen()
        {
            var uut = new Field(0, 2);
            Assert.That(uut.ToString(), Is.EqualTo("[0, green]"));
        }
    }
}