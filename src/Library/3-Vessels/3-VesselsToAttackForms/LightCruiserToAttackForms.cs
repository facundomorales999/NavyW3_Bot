using System.Collections.Generic;
using System.IO;

namespace Library
{
    public class LightCruiserToAttackForms : AbstractVesselsToAttackForms
    {
        public LightCruiserToAttackForms()
        :base(new PuntoonToAttackForms())
        {
        }
        public override List<string> ToString(AbstractVessel vessel, string lang)
        {
            if (vessel is LightCruiser)
            {
                string[] attackForms = File.ReadAllLines(@"..\..\..\..\language\"+lang+@"\AttackForms.txt");
                return new List<string> { attackForms[0],attackForms[1] };
            }
            else
            {
                return this.SendNext(vessel,lang);
            }
        }
    }
}