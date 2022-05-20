using Entidades.enums;
using Entidades;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IdUsuario()
        {
            Puzzle puzzle = new Puzzle();
            Puzzle puzzle2 = new Puzzle();


            Assert.AreEqual(2, puzzle2.Id);
        }
    }
}