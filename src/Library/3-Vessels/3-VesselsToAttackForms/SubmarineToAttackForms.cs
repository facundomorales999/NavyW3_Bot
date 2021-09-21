using System.Collections.Generic;
using System.IO;

namespace Library
{
    public class SubmarineToAttackForms : AbstractVesselsToAttackForms
    {
        public SubmarineToAttackForms()
        :base(new NullVesselsToAttackForms())
        {
        }
        public override List<string> ToString(AbstractVessel vessel, string lang)
        {
            if (vessel is Submarine)
            {
                string[] attackForms = File.ReadAllLines(@"..\..\..\..\language\"+lang+@"\AttackForms.txt");
                return new List<string> {attackForms[0], attackForms[1]};
            }
            else
            {
                return this.SendNext(vessel,lang);
            }
        }
    }
}