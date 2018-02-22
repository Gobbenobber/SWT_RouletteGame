using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RouletteGame.Legacy;
using NSubstitute;

namespace RouletteGame.Unittests
{
    [TestFixture]
    public class FieldUnitTests
    {
        private Field _uut;
        [SetUp]
        public void Setup()
        {
            _uut = new Field(0,2); 
        }
    }
}