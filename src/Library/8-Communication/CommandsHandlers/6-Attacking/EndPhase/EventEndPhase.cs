
using System;
using System.Collections.ObjectModel;

namespace Library
{
    public class EventEndPhase : AbstractEndPhase
    {
        public EventEndPhase()
        :base(new NullEndPhase())
        {
        }
        public override void DoEndPhase(ReadOnlyCollection<AbstractPlayer> players)
        {
            Random rnd = new Random();
            AbstractNextEvent nextEvent = new HeadNextEvent();
            int rndInt = rnd.Next(0,5);
            if (rndInt<=3)
            {
                IEvent catastrophe = nextEvent.NextEvent(rndInt);
                catastrophe.DoEvent(players);
            }
            this.SendNext(players);
        }
    }
}