using System.Collections.Generic;
using System.IO;

namespace Library
{
    public class FrigateToAttackForms : AbstractVesselsToAttackForms
    {
        public FrigateToAttackForms()
        :base(new HeavyCruiserToAttackForms())
        {
        }
        public override List<string> ToString(AbstractVessel vessel, string lang)
        {
            if (vessel is Frigate)
            {
                string[] attackForms = File.ReadAllLines(@"..\..\..\..\language\"+lang+@"\AttackForms.txt");
                return new List<string> { attackForms[0] };
            }
            else
            {
                return this.SendNext(vessel,lang);
            }
        }
    }
}