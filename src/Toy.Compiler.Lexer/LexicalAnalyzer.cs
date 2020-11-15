using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy.Compiler.Lexer
{
    public class LexicalAnalyzer
    {
        public LexicalAnalyzer(string text)
        {
            TextWindow = new SlidingTextWindow(text);
        }

        private List<Exception> errors;
        public SlidingTextWindow TextWindow { get; private set; }
        public bool HasErrors { get { return errors != null; } }

        public void Start()
        {
            TextWindow.Start();
            errors = null;
        }
    }
}
