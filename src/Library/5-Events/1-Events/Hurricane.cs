using System;
using System.Collections.ObjectModel;

namespace Library
{
    public class Hurricane : IEvent
    {
        public void DoEvent(ReadOnlyCollection<AbstractPlayer> participants)
        {
            // Dependencias.
            AbstractAttacker hurricane = new HurricaneAttack();

            Random random = new Random();
            int radio = 3;
            int lengthX = participants[0].XLength();
            int lengthY = participants[0].YLength();
            int randomX = random.Next(radio, lengthX - radio);
            int randomY = random.Next(radio, lengthY - radio);

            foreach (AbstractPlayer participant in participants)
            {
                for (int y = 0; y < lengthY; y++)
                {
                    participant.AttackAt(randomX, y, hurricane);
                }
                for (int x = 0; x < lengthX; x++)
                {
                    participant.AttackAt(x, randomY, hurricane);
                }
            }
        }
    }
}