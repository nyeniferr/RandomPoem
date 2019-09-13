using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poem
{
    public abstract class Base
    {
        protected Random random = new Random();

        protected string[] baseElements = { };
        public string Element { get; set; }
        public abstract string GetOptional();
        public virtual string[] FillBaseElements(string grammarObj)
        {
            try
            {
                string noun = string.Empty;
                int i = 0;
                string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"Files\"+grammarObj+".txt");
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                while ((noun = file.ReadLine()) != null)
                {
                    if (noun.Split(',').Length > 0)
                    {
                        baseElements = new string[noun.Split(',').Length];

                        foreach (String points in noun.Split(','))
                        {
                            baseElements[i] = Convert.ToString(points);
                            i++;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return baseElements;
        }

        public virtual string GetBaseElement(string grammarObj)
        {
            FillBaseElements(grammarObj);
            if (baseElements.Length>0)
            {
                int pos = random.Next(0, baseElements.Length);
                return baseElements[pos];
            }
            else
            {
                return string.Empty;
            }
        }

    }
}
