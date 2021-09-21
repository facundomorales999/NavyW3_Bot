using System;
using System.Collections.ObjectModel;

namespace Library
{
    public abstract class AbstractStateManager : AbstractItemSaver
    {
        private int[] _state;
        public ReadOnlyCollection<int> State
        {
            get
            {
                return Array.AsReadOnly<int>(this._state);
            }
        }
        public AbstractStateManager(int size, int health)
        : base(size)
        {
            this._state = new int[size];
            this.CleanState(health);
        }
        protected void CleanState(int health)
        {
            for (int i = 0; i < this._state.Length; i++)
            {
                this._state[i] = health;
            }
        }
        public bool IsAlive()
        {
            foreach (int i in State)
            {
                if (i != 0)
                {
                    return true;
                }
            }
            return false;
        }
        public virtual bool ReceiveAttackAt(AbstractAttackable table, AbstractAttacker attack)
        {
            bool isAttackable = this.IsAttackable(table, attack);
            if (isAttackable)
            {
                this._state[attack.Position] -= 1;
                if (this._state[attack.Position] == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public virtual bool ReceiveDestruction(AbstractAttackable table, AbstractAttacker attack)
        {
            if (this.IsAttackable(table, attack))
            {
                this.CleanState(0);
                return true;
            }
            return false;
        }
    }
}