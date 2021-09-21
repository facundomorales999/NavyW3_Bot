using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class ItemValidatorTest
    {
        private IItemValidator _anticraft;
        private IItemValidator _armor;
        private IItemValidator _hackers;
        private IItemValidator _kong;
        private IItemValidator _sateliteLock;

        private AbstractVessel _vessel;
        private AbstractTable _tab;
        [SetUp]
        public void Setup()
        {
            this._anticraft = new AntiaircraftMissileValidator();
            this._armor = new ArmorValidator();
            this._hackers = new HackersValidator();
            this._kong = new KongValidator();
            this._sateliteLock = new SateliteLockValidator();

            this._tab = new Table();
        }
        [Test]
        public void AddableAnticraft()
        {
            this._vessel = new Battleship();
            Assert.IsTrue(this._anticraft.IsAddable(0,this._vessel,this._tab));
        }
        [Test]
        public void AddableArmor()
        {
            this._vessel = new Battleship();
            Assert.IsTrue(this._armor.IsAddable(0,this._vessel,this._tab));
        }
        [Test]
        public void AddableHackers()
        {
            this._vessel = new Puntoon();
            Assert.IsTrue(this._hackers.IsAddable(0,this._vessel,this._tab));
        }

        [Test]
        public void AddableKong()
        {
            this._vessel = new Battleship();
            Assert.IsTrue(this._kong.IsAddable(0,this._vessel,this._tab));
        }
        [Test]
        public void AddableSatelite()
        {
            this._vessel = new Battleship();
            Assert.IsTrue(this._sateliteLock.IsAddable(0,this._vessel,this._tab));
        }
    }
}