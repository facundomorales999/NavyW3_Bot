using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Library
{
    public abstract class AbstractVesselSaver
    {
        protected Dictionary<(int, int), AbstractVessel> _vessels;
        protected AbstractVesselSaver()
        {
            this._vessels = new Dictionary<(int, int), AbstractVessel>();
        }
        protected bool AddVessel(int up, int left, AbstractVessel vessel)
        {
            this._vessels.Add((up, left), vessel);
            return true;
        }
        protected AbstractVessel GetVessel((int, int) key)
        {
            return this._vessels[key];
        }
        public ReadOnlyCollection<AbstractVessel> GetListOfVessels()
        {
            return this._vessels.Values.ToList<AbstractVessel>().AsReadOnly();
        }
        protected bool RemoveVessel((int, int) key)
        {
            this._vessels.Remove(key);
            return true;
        }
    }
}