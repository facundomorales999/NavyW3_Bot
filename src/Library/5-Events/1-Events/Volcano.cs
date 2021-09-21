using System;
using System.Collections.ObjectModel;

namespace Library
{
    public class Volcano : IEvent
    {
        public void DoEvent(ReadOnlyCollection<AbstractPlayer> participants)
        {
            // Dependencias.
            AbstractAttacker lava = new LavaAttack();

            Random random = new Random();
            int radio = 2;
            int lengthX = participants[0].XLength();
            int lengthY = participants[0].YLength();
            int randomX = random.Next(radio, lengthX - radio);
            int randomY = random.Next(radio, lengthY - radio);
            foreach (AbstractPlayer participant in participants)
            {
                for (int y = randomY - radio; y <= randomY + radio; y++)
                {
                    for (int x = randomX - radio; x <= randomX + radio; x++)
                    {
                        participant.AttackAt(x, y, lava);
                    }
                }
            }
        }
    }
}