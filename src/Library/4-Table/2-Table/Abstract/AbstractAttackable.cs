using System;
using System.Collections.Generic;

namespace Library
{
    public abstract class AbstractAttackable : AbstractField
    {
        protected AbstractAttackable(int x, int y)
        : base(x, y)
        {
        }
        public void AttackAt(int x, int y, AbstractAttacker attack)
        {
            if (this.IsAVessel(x, y))
            {
                (int, int) posicionVessel = this.GetLeftUp(x, y);

                int xAux = posicionVessel.Item1;
                int yAux = posicionVessel.Item2;

                if (y == yAux)
                {
                    // Actualizo la Posicion relativa al barco en attack.
                    attack.Position = x - xAux;
                }
                else
                {
                    // Actualizo la Posicion relativa al barco en attack.
                    attack.Position = y - yAux;
                }

                bool successfully = this.GetVessel((xAux, yAux)).ReceiveAttackAt(this, attack);

                if (successfully)
                {
                    this.UpdateAt(x, y, new DeadVessel());
                }
                else
                {
                    this.UpdateAt(x, y, new LivedVessel());
                }
            }
            else
            {
                if (attack is MissileAttack)
                {
                    this.UpdateAt(x, y, new AttackedWater());
                }
                else
                {
                    this.UpdateAt(x, y, new UnattackableWater());
                }
            }
        }
        public List<(int,int)> DestroyAttack(AbstractAttacker attack)
        {
            if (this.IsAVessel(attack.X, attack.Y))
            {
                bool deleted = this.GetVessel((attack.X, attack.Y)).ReceiveDestruction(this, attack);
                if (deleted)
                {
                    this.RemoveVessel(attack.X, attack.Y, new DeadVessel());
                }
                return this.VesselCoordinates(attack.X, attack.Y);
            }
            else
            {
                return new List<(int, int)> ();
            }
        }
        public void RandomAttack(AbstractAttacker attack)
        {
            Random random = new Random();
            int randomX = random.Next(0, this.XLength());
            int randomY = random.Next(0, this.YLength());
            this.AttackAt(randomX, randomY, attack);
        }
    }
}