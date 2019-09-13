using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poem
{
    public class Verb : Base
    {
        public Verb()
        {
        }

        public override string GetOptional()
        {
            int option = new Random().Next(0, 3);
            string baseEl = string.Empty;
            string optionalEl = string.Empty;
            switch (option)
            {
                case 0:
                    baseEl = new Preposition().GetBaseElement("Preposition");
                    optionalEl = new Preposition().GetOptional();
                    return baseEl + ' ' + optionalEl;
                case 1:
                    baseEl = new Pronoun().GetBaseElement("Pronoun");
                    optionalEl = new Pronoun().GetOptional();
                    return baseEl + ' ' + optionalEl;
                case 2:
                    return string.Empty;
            }
            return string.Empty;
        }
    }
}
