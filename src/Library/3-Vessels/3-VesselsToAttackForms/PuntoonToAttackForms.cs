using System.Collections.Generic;
using System.IO;

namespace Library
{
    public class PuntoonToAttackForms : AbstractVesselsToAttackForms
    {
        public PuntoonToAttackForms()
        :base(new SubmarineToAttackForms())
        {
        }
        public override List<string> ToString(AbstractVessel vessel, string lang)
        {
            if (vessel is Puntoon)
            {
                string[] attackForms = File.ReadAllLines(@"..\..\..\..\language\"+lang+@"\AttackForms.txt");
                return new List<string> {};
            }
            else
            {
                return this.SendNext(vessel,lang);
            }
        }
    }
}