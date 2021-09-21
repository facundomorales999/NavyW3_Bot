using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class AbstractFieldTest
    {
        private Table _tab;
        private MeteorShower _meteorShower;
        private Battleship _battleship;
        [SetUp]
        public void Setup()
        {
            this._tab = new Table();
            this._meteorShower = new MeteorShower();
            this._battleship = new Battleship();

        }
        [Test]
        public void EmptyWater()
        {
            Assert.IsTrue(this._tab.IsEmpty());
        }
        [Test]
        public void EmptyAfterEvent()
        {
            List<AbstractPlayer> aux = new List<AbstractPlayer> { new Player(0, "Matias", null) };
            this._meteorShower.DoEvent(aux.AsReadOnly());
            Assert.IsTrue(this._tab.IsEmpty());
        }
        [Test]
        public void HiddenVessel()
        {

            TableToString toString = new TableToString();
            this._tab.AddVessel(1,1,this._battleship,true);
            Assert.AreEqual('4', toString.ToString(this._tab).Split("\n")[1][1]);
        }
        [Test]
        public void GetLeftUpHorizontal()
        {
            this._tab.AddVessel(1,1,this._battleship,false);
            Assert.AreEqual((1,1),this._tab.GetLeftUp(3,1));
        }
        [Test]
        public void GetLeftUpVertical()
        {
            this._tab.AddVessel(1,1,this._battleship,true);
            Assert.AreEqual((1,1),this._tab.GetLeftUp(1,3));
        }        
    }
}