using System;
using NUnit.Framework;

namespace Library.Test
{
    public class RemoveVesselsTest
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
        public void NormalVerticalRemove()
        {
            this._tab.AddVessel(1,1,this._battleship,true);
            this._tab.RemoveVessel(1,3,new DeadVessel());
            Assert.IsTrue(this._tab.IsEmpty());
            
        }
        [Test]
        public void NormalHorizontalRemove()
        {
            this._tab.AddVessel(1,1,this._battleship,false);
            this._tab.RemoveVessel(3,1, new DeadVessel());
            Assert.IsTrue(this._tab.IsEmpty());
        }
        [Test]
        public void EmptyRemove()
        {
            this._tab.RemoveVessel(1,1, new UnattackableWater());
            Assert.IsTrue(this._tab.IsEmpty());
        }
        [Test]
        public void RemoveOutTable()
        {
            this._tab.AddVessel(25,30,this._battleship,false);
            Assert.IsTrue(this._tab.IsEmpty());
        }
    }
}