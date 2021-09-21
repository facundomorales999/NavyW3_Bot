using NUnit.Framework;

namespace Library.Test
{
    public class AddVesselsTest
    {
        private Table _tab;
        private Battleship _battleship;
        [SetUp]
        public void Setup()
        {
            this._tab = new Table();

            this._battleship = new Battleship();
        }
        [Test]
        public void EmptyTable()
        {
            Assert.IsTrue(this._tab.IsEmpty());
        }
        [Test]
        public void NormalVerticalAdd()
        {
            TableToString toString = new TableToString();
            this._tab.AddVessel(1,1,this._battleship,true);
            Assert.AreEqual('4', toString.ToString(this._tab).Split("\n")[6][1]);
        }
        [Test]
        public void NormalHorizontalAdd()
        {
            TableToString toString = new TableToString();
            this._tab.AddVessel(1,1,this._battleship,false);
            Assert.AreEqual('4', toString.ToString(this._tab).Split("\n")[1][6]);
        }
        [Test]
        public void EdgeAdd()
        {
            this._tab.AddVessel(0,0,this._battleship,true);
            Assert.IsTrue(this._tab.IsEmpty());
        }
        [Test]
        public void NotAtAllInTable()
        {
            this._tab.AddVessel(12,1,this._battleship,false);
            Assert.IsTrue(this._tab.IsEmpty());
        }
        [Test]
        public void AllOutTable()
        {
            this._tab.AddVessel(25,30,this._battleship,false);
            Assert.IsTrue(this._tab.IsEmpty());
        }
    }
}