using NUnit.Framework;

namespace H2OLib.Test
{
    [TestFixture]
    public class H2OTests
    {
        [Test]
        public void GivenGasStateThenExpectCorrectTemps()
        {
            var h2o = new H2O(H2O.State.Gas);
            Assert.That(h2o.MinTemp, Is.EqualTo(100));
            Assert.That(h2o.MaxTemp, Is.EqualTo(374));
        }

        [Test]
        public void GivenLiquidStateThenExpectCorrectTemps()
        {
            var h2o = new H2O(H2O.State.Liquid);
            Assert.That(h2o.MinTemp, Is.EqualTo(0));
            Assert.That(h2o.MaxTemp, Is.EqualTo(100));
        }

        [Test]
        public void GivenSolidStateThenExpectCorrectTemps()
        {
            var h2o = new H2O(H2O.State.Solid);
            Assert.That(h2o.MinTemp, Is.EqualTo(-230));
            Assert.That(h2o.MaxTemp, Is.EqualTo(0));
        }
    }
}
