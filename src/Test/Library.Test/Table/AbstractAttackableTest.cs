using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class AbstractAttackableTest
    {
        private Table _tab;
        private Battleship _battleship;
        private MissileAttack _missile;
        private LoadAttack _load;
        private Armor _armor;
        private MeteorShower _meteorShower;
        [SetUp]
        public void Setup()
        {
            this._tab = new Table();

            this._battleship = new Battleship();

            this._missile = new MissileAttack();
            this._load = new LoadAttack();

            this._armor = new Armor();

            this._meteorShower = new MeteorShower();
        }
        [Test]
        public void EmptyAfterAttack()
        {
            this._tab.AddVessel(1,1,this._battleship,true);

            this._tab.AttackAt(1,1,this._missile);
            this._tab.AttackAt(1,2,this._missile);
            this._tab.AttackAt(1,3,this._missile);
            this._tab.AttackAt(1,4,this._missile);
            this._tab.AttackAt(1,5,this._missile);
            this._tab.AttackAt(1,6,this._missile);

            this._tab.AttackAt(5,5,this._missile);

            Assert.IsTrue(this._tab.IsEmpty());
        }
        [Test]
        public void MissilToWater()
        {
            TableToString toString = new TableToString();
            this._tab.AttackAt(1,1,this._missile);
            Assert.AreEqual('1', toString.ToString(this._tab).Split("\n")[1][1]);
        }
        [Test]
        public void LoadToWater()
        {
            TableToString toString = new TableToString();
            this._tab.AttackAt(1,1,this._load);
            Assert.AreEqual('5', toString.ToString(this._tab).Split("\n")[1][1]);
        }
        [Test]
        public void FoundedVessel()
        {

            TableToString toString = new TableToString();
            this._battleship.AddItem(0,this._armor,this._tab,new ArmorValidator());
            this._tab.AddVessel(1,1,this._battleship,true);
            try
            {
                this._tab.AttackAt(1,1,this._load);
            }
            catch(ArmorAttackException)
            {
                Assert.AreEqual('4', toString.ToString(this._tab).Split("\n")[1][1]);
            }
        }
        [Test]
        public void DeadVesselInTable()
        {
            TableToString toString = new TableToString();
            this._tab.AddVessel(1,1,this._battleship,true);
            this._tab.AttackAt(1,1,this._load);
            Assert.AreEqual('2', toString.ToString(this._tab).Split("\n")[1][1]);
        }
    }
}