using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poem
{
    public class Preposition : Base
    {
        public Preposition()
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
                    baseEl = new Noun().GetBaseElement("Noun");
                    optionalEl = new Noun().GetOptional();
                    return baseEl + ' ' + optionalEl;
                case 1:
                    baseEl = new Pronoun().GetBaseElement("Pronoun");
                    optionalEl = new Pronoun().GetOptional();
                    return baseEl + ' ' + optionalEl;
                case 2:
                    baseEl = new Adjective().GetBaseElement("Adjective");
                    optionalEl = new Adjective().GetOptional();
                    return baseEl + ' ' + optionalEl;
            }
            return string.Empty;
        }
    }
}
