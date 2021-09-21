using NUnit.Framework;

namespace Library
{
    public class IItemValidatorsExceptions
    {
        // Validadores.
        private IItemValidator _antiAircraftValidator;
        private IItemValidator _armorValidator;
        private IItemValidator _hackersValidator;
        private IItemValidator _kongValidator;
        private IItemValidator _sateliteLockValidator;

        // Vessels.
        private AbstractVessel _battleShip;
        private AbstractVessel _heavyCruiser;
        private AbstractVessel _puntoon;
        private AbstractVessel _submarine;
        private AbstractVessel _frigate;

        // Items.
        private IItem _antiAircraftMissile;
        private IItem _armor;
        private IItem _hackers;
        private IItem _kong;
        private IItem _sateliteLock;

        // Table.
        private AbstractTable _table;

        [SetUp]
        public void Setup()
        {
            this._antiAircraftValidator = new AntiaircraftMissileValidator();
            this._armorValidator = new ArmorValidator();
            this._hackersValidator = new HackersValidator();
            this._kongValidator = new KongValidator();
            this._sateliteLockValidator = new SateliteLockValidator();

            this._battleShip = new Battleship();
            this._heavyCruiser = new HeavyCruiser();
            this._puntoon = new Puntoon();
            this._submarine = new Submarine();
            this._frigate = new Frigate();

            this._antiAircraftMissile = new AntiaircraftMissile();
            this._armor = new Armor();
            this._hackers = new Hackers();
            this._kong = new Kong();
            this._sateliteLock = new SateliteLock();

            this._table = new Table();
        }

        // AntiaircraftMissileValidator.
        // Este item solo se puede tener una vez en todo el barco, y no puede superponerse a otros items.
        [Test]
        public void NoRepetitiveItemExceptionAntiAircraftTest()
        {
            // Act.
            _heavyCruiser.AddItem(1, _antiAircraftMissile, _table, _antiAircraftValidator);
            // Assert.
            Assert.Throws<Library.NoRepetitiveItemException>(() => _heavyCruiser.AddItem(1, _antiAircraftMissile, _table, _antiAircraftValidator));
        }

        [Test]
        public void NoEmptyPositionExceptionAntiAircraftTest()
        {
            // Act.
            _heavyCruiser.AddItem(1, _armor, _table, _armorValidator);
            // Assert.
            Assert.Throws<Library.NoEmptyPositionException>(() => _heavyCruiser.AddItem(1, _antiAircraftMissile, _table, _antiAircraftValidator));
        }

        // Armor.
        // Item no puede superponerse a otros.
        [Test]
        public void NoEmptyPositionExceptionArmorTest()
        {
            // Act.
            _heavyCruiser.AddItem(1, _antiAircraftMissile, _table, _antiAircraftValidator);
            // Assert.
            Assert.Throws<Library.NoEmptyPositionException>(() => _heavyCruiser.AddItem(1, _armor, _table, _armorValidator));
        }

        // Hackers.
        // Este item no se puede superponer a otros y solo puede ser puesto en un barco del tipo Pontoon.
        [Test]
        public void WrongVesselExceptionFalseCaseTest()
        {
            // Assert.
            Assert.Throws<Library.WrongVesselException>(() => _heavyCruiser.AddItem(1, _hackers, _table, _hackersValidator));
        }
        [Test]
        public void WrongVesselExceptionTrueCaseTest()
        {
            // Assert.
            Assert.True(_puntoon.AddItem(0, _hackers, _table, _hackersValidator));
        }
        [Test]
        public void NoEmptyPositionExceptionHackersTest()
        {
            // Act.
            _puntoon.AddItem(0, _antiAircraftMissile, _table, _antiAircraftValidator);
            // Assert.
            Assert.Throws<Library.NoEmptyPositionException>(() => _puntoon.AddItem(0, _hackers, _table, _hackersValidator));
        }

        // SateliteLock.
        // Este item no se puede superponer a otros y solo puede estar ensolo un barco de toda la flota.

        [Test]
        public void NoRepetitiveItemExceptionInSameVesselSateliteLockTest()
        {
            // Arrange.
            _table.AddVessel(2, 2, _heavyCruiser, true);
            // Act.
            _heavyCruiser.AddItem(1, _sateliteLock, _table, _sateliteLockValidator);
            // Assert.
            Assert.Throws<Library.NoRepetitiveItemException>(() => _heavyCruiser.AddItem(2, _sateliteLock, _table, _sateliteLockValidator));
        }

        [Test]
        public void NoRepetitiveItemExceptionInDifferentVesselSateliteLockTest()
        {
            // Arrange.
            _table.AddVessel(2, 2, _heavyCruiser, true);
            _table.AddVessel(8, 8, _frigate, true);
            // Act.
            _heavyCruiser.AddItem(1, _sateliteLock, _table, _sateliteLockValidator);
            // Assert.
            Assert.Throws<Library.NoRepetitiveItemException>(() => _frigate.AddItem(2, _sateliteLock, _table, _sateliteLockValidator));
        }

        [Test]
        public void NoEmptyPositionExceptionSateliteLockTest()
        {
            // Act.
            _heavyCruiser.AddItem(1, _sateliteLock, _table, _sateliteLockValidator);
            // Assert.
            Assert.Throws<Library.NoEmptyPositionException>(() => _heavyCruiser.AddItem(1, _sateliteLock, _table, _sateliteLockValidator));
        }

        // Kong.
        // Este item para sea agregable el barco no puede tener otros items y el barco debe ser mas largo que 4.

        [Test]
        public void NeededEmptyVesselExceptionInSamePositionTest()
        {
            // Act.
            _heavyCruiser.AddItem(1, _sateliteLock, _table, _sateliteLockValidator);
            // Assert.
            Assert.Throws<Library.NeededEmptyVesselException>(() => _heavyCruiser.AddItem(1, _kong, _table, _kongValidator));
        }

        [Test]
        public void NeededEmptyVesselExceptionInDifferentPositionTest()
        {
            // Act.
            _battleShip.AddItem(1, _sateliteLock, _table, _sateliteLockValidator);
            // Assert.
            Assert.Throws<Library.NeededEmptyVesselException>(() => _battleShip.AddItem(2, _kong, _table, _kongValidator));
        }

        [Test]
        public void TooShortVesselExceptionTest()
        {
            // Assert.
            Assert.Throws<Library.TooShortVesselException>(() => _frigate.AddItem(1, _kong, _table, _kongValidator));
        }
    }
}