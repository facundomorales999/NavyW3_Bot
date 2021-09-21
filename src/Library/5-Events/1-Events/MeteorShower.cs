using System;
using System.Collections.ObjectModel;

namespace Library
{
    public class MeteorShower : IEvent
    {
        private int _times = 10;
        public void DoEvent(ReadOnlyCollection<AbstractPlayer> participants)
        {
            // Dependencias.
            AbstractAttacker meteor = new MeteorAttack();

            Random random = new Random();
            foreach (AbstractPlayer participant in participants)
            {
                for (int i = 0; i < this._times; i++)
                {
                    participant.RandomAttack(meteor);
                }
            }
        }
    }
}