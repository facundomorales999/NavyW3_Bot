using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class Item
    {
        private Table _tab;
        private Battleship _battleship;

        private MissileAttack _missile;
        private LoadAttack _load;
        private LavaAttack _lava;
        private GodzillaAttack _godzilla;

        private SateliteLock _sateliteLock;
        private Armor _armor;
        private AntiaircraftMissile _anticraftMissile;
        private Kong _kong;
        private Hackers _hackers;
        [SetUp]
        public void Setup()
        {
            this._tab = new Table();

            this._battleship = new Battleship();

            this._missile = new MissileAttack();
            this._load = new LoadAttack();
            this._lava = new LavaAttack();
            this._godzilla = new GodzillaAttack();

            this._sateliteLock = new SateliteLock();
            this._armor = new Armor();
            this._anticraftMissile = new AntiaircraftMissile();
            this._kong = new Kong();
            this._hackers = new Hackers();
            
        }
        [Test]
        public void SateliteLockWorking()
        {
            this._battleship.AddItem(0,this._sateliteLock,this._tab,new SateliteLockValidator());
            this._tab.AddVessel(1,1,this._battleship,true);
            try
            {
                this._tab.AttackAt(1,1,this._missile);
            }
            catch(SateliteLockAttackException)
            {
                Assert.AreEqual(1, this._battleship.State[0]);
            }
            
        }
        [Test]
        public void SateliteLockNotWorking()
        {
            this._battleship.AddItem(0,this._sateliteLock,this._tab,new SateliteLockValidator());
            this._tab.AddVessel(1,1,this._battleship,true);
            this._tab.AttackAt(1,1,this._lava);
            Assert.AreEqual(0, this._battleship.State[0]);
        }
        [Test]
        public void ArmorWorking()
        {
            this._battleship.AddItem(0,this._armor,this._tab,new ArmorValidator());
            this._tab.AddVessel(1,1,this._battleship,true);
            try
            {
                this._tab.AttackAt(1,1,this._load);
            }
            catch(ArmorAttackException)
            {
                Assert.AreEqual(1, this._battleship.State[0]);
            }
        }
        public void ArmorNotWorking()
        {
            this._battleship.AddItem(0,this._armor,this._tab,new ArmorValidator());
            this._tab.AddVessel(1,1,this._battleship,true);
            this._tab.AttackAt(1,1,this._lava);
            Assert.AreEqual(0, this._battleship.State[0]);
        }
        [Test]
        public void AntiaircraftMissileWorking()
        {
            this._battleship.AddItem(0,this._anticraftMissile,this._tab,new AntiaircraftMissileValidator());
            this._tab.AddVessel(1,1,this._battleship,true);
            try
            {   
                this._tab.AttackAt(1,1,this._missile);
            }catch(AntiaircraftMissileException)
            {
                Assert.AreEqual(1, this._battleship.State[0]);
            }
            
        }
        [Test]
        public void AntiaircraftMissileNotWorking()
        {
            this._battleship.AddItem(0,this._anticraftMissile,this._tab,new AntiaircraftMissileValidator());
            this._tab.AddVessel(1,1,this._battleship,true);
            this._tab.AttackAt(1,1,this._lava);
            Assert.AreEqual(0, this._battleship.State[0]);
        }

        [Test]
        public void KongWorking()
        {
            this._battleship.AddItem(0,this._kong,this._tab,new KongValidator());
            this._tab.AddVessel(1,1,this._battleship,true);
            try
            {
                this._tab.AttackAt(1,1,this._godzilla);
            }
            catch(KongAttackException)
            {
                Assert.AreEqual(1, this._battleship.State[0]);
            }
        }
        [Test]
        public void KongNotWorking()
        {
            this._battleship.AddItem(0,this._kong,this._tab,new KongValidator());
            this._tab.AddVessel(1,1,this._battleship,true);
            this._tab.AttackAt(1,1,this._lava);
            Assert.AreEqual(0, this._battleship.State[0]);
        }
        [Test]
        public void HackersNotWorking()
        {
            this._tab.AddVessel(1,1,this._battleship,true);
            this._tab.AttackAt(1,1,this._load);
            Assert.AreEqual(0, this._battleship.State[0]);
        }
    }
}