using System.Collections.Generic;
using NUnit.Framework;

namespace Library
{
    public class EventsTest
    {
        private IEvent _godzilla;
        private IEvent _hurricane;
        private IEvent _meteorShower;
        private IEvent _volcano;
        private AbstractPlayer _player;
        [SetUp]
        public void Setup()
        {
            this._godzilla = new Godzilla();
            this._hurricane = new Hurricane();
            this._meteorShower = new MeteorShower();
            this._volcano = new Volcano();
            this._player = new Player(0, "Matias", null);
        }
        [Test]
        public void RandomGodzilla()
        {
            this._godzilla.DoEvent(new List<AbstractPlayer> { this._player }.AsReadOnly());
            Assert.IsTrue(true);
        }

        [Test]
        public void RandomHurricane()
        {
            this._hurricane.DoEvent(new List<AbstractPlayer> { this._player }.AsReadOnly());
            Assert.IsTrue(true);
        }
        [Test]
        public void RandomMeteorShower()
        {
            this._meteorShower.DoEvent(new List<AbstractPlayer> { this._player }.AsReadOnly());
            Assert.IsTrue(true);
        }
        [Test]
        public void RandomVolcano()
        {
            this._volcano.DoEvent(new List<AbstractPlayer> { this._player }.AsReadOnly());
            Assert.IsTrue(true);
        }
    }
}