using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class AttackVesselsTest
    {
        private Table _tab;
        private Battleship _battleship;
        private Submarine _submarine;
        private HeavyCruiser _heavyCruiser;
        private MissileAttack _missile;
        private LoadAttack _load;
        private Armor _armor;
        private MeteorAttack _meteor;
        [SetUp]
        public void Setup()
        {
            this._tab = new Table();

            this._battleship = new Battleship();
            this._submarine = new Submarine();
            this._heavyCruiser = new HeavyCruiser();

            this._missile = new MissileAttack();
            this._load = new LoadAttack();

            this._armor = new Armor();

            this._meteor = new MeteorAttack();
        }
        [Test]
        public void DeadVessel()
        {
            this._tab.AddVessel(1,1,this._battleship,true);
            this._tab.AttackAt(1,1,this._load);
            Assert.AreEqual(0, this._battleship.State[0]);
        }
        [Test]
        public void LiveVesselAfterAttack()
        {
            this._tab.AddVessel(1,1,this._heavyCruiser,true);
            this._tab.AttackAt(1,1,this._load);
            Assert.AreEqual(1, this._heavyCruiser.State[0]);
        }
        [Test]
        public void SubmarineMissile()
        {
            this._tab.AddVessel(1,1,this._submarine,true);
            this._tab.AttackAt(1,1,this._missile);
            Assert.AreEqual(1, this._submarine.State[0]);
        }
        [Test]
        public void SubmarineLoad()
        {
            this._tab.AddVessel(1,1,this._submarine,true);
            this._tab.AttackAt(1,1,this._load);
            Assert.AreEqual(0, this._submarine.State[0]);
        }
    }
}