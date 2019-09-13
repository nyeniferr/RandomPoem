using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poem
{
    public class Noun : Base
    {

        public Noun()
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
                    baseEl = new Verb().GetBaseElement("Verb");
                    optionalEl = new Verb().GetOptional();
                    return baseEl + ' ' + optionalEl;
                case 1:
                    baseEl = new Preposition().GetBaseElement("Preposition");
                    optionalEl = new Preposition().GetOptional();
                    return baseEl + ' ' + optionalEl;
                case 2:
                    return string.Empty;
            }
            return string.Empty;
        }


    }
}
