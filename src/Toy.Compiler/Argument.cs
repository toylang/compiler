using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy.Compiler
{
    public class Argument
    {
        public string SourceFile { get; set; }

        static Argument Parse(string [] args)
        {
            return new Argument();
        }
    }
}
