using System.Collections.Generic;
using NUnit.Framework;

namespace Library.Test
{
    public class AttackValidatorTest
    {
        private AntiaircraftMissileAttackValidator _anticraft;
        private ArmorAttackValidator _armor;
        private HackersAttackValidator _hackers;
        private KongAttackValidator _kong;
        private SateliteLockAttackValidator _sateliteLock;

        private Table _tab;
        private AbstractAttacker _attacker;

        [SetUp]
        public void Setup()
        {
            this._anticraft = new AntiaircraftMissileAttackValidator();
            this._armor = new ArmorAttackValidator();
            this._hackers = new HackersAttackValidator();
            this._kong = new KongAttackValidator();
            this._sateliteLock = new SateliteLockAttackValidator();

            this._tab = new Table();
        }
        [Test]
        public void AvoidingAnticraftMissile()
        {
            try
            {
                this._attacker = new MissileAttack();
            }
            catch(AntiaircraftMissileException)
            {
                Assert.IsTrue(this._anticraft.AvoidAttack(this._tab,this._attacker));
            }
        }
        [Test]
        public void NotAvoidingAnticraftMissile()
        {
            Assert.IsFalse(this._anticraft.AvoidAttack(this._tab,this._attacker));
        }
        [Test]
        public void AvoidingArmor()
        {
            try
            {
                this._attacker = new MissileAttack();
            }
            catch(ArmorAttackException)
            {
                Assert.IsTrue(this._armor.AvoidAttack(this._tab,this._attacker));
            }
        }
        [Test]
        public void NotAvoidingArmor()
        {
            this._attacker = new LavaAttack();
            Assert.IsFalse(this._armor.AvoidAttack(this._tab,this._attacker));
        }
        [Test]
        public void NotAvoidingHackers()
        {
            Assert.IsFalse(this._hackers.AvoidAttack(this._tab,this._attacker));
        }
        [Test]
        public void AvoidingKong()
        {
            try
            {
                this._attacker = new GodzillaAttack();
            }
            catch(KongAttackException)
            {
                Assert.IsTrue(this._kong.AvoidAttack(this._tab,this._attacker));
            }
        }
        
        [Test]
        public void NotAvoidingKong()
        {
            this._attacker = new LavaAttack();
            Assert.IsFalse(this._kong.AvoidAttack(this._tab,this._attacker));
        }
        
        [Test]
        public void AvoidingSateliteLock()
        {
            try
            {
                this._attacker = new LoadAttack();
            }catch(SateliteLockAttackException)
            {
                Assert.IsTrue(this._sateliteLock.AvoidAttack(this._tab,this._attacker));
            }
        }
        [Test]
        public void NotAvoidingSateliteLock()
        {
            this._attacker = new LavaAttack();
            Assert.IsFalse(this._sateliteLock.AvoidAttack(this._tab,this._attacker));
        }

    }
}