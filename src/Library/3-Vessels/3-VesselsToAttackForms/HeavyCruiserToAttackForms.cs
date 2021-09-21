using System.Collections.Generic;
using System.IO;

namespace Library
{
    public class HeavyCruiserToAttackForms : AbstractVesselsToAttackForms
    {
        public HeavyCruiserToAttackForms()
        :base(new LightCruiserToAttackForms())
        {
        }
        public override List<string> ToString(AbstractVessel vessel, string lang)
        {
            if (vessel is HeavyCruiser)
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