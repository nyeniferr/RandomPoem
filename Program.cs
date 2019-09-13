using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poem
{
    public class Program         
    {
        
        static void Main(string[] args)
        {
            int poemLength = 5;
            for(int i=0; i < poemLength; i++)
            {
                string line= GetLine();
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }

        public static string GetLine()
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
                    baseEl = new Preposition().GetBaseElement("Preposition");
                    optionalEl = new Preposition().GetOptional();
                    return baseEl +' '+ optionalEl;
                case 2:
                    baseEl = new Pronoun().GetBaseElement("Pronoun");
                    optionalEl = new Pronoun().GetOptional();
                    return baseEl + ' ' + optionalEl;
            }
            return string.Empty;
        }
    }
}
