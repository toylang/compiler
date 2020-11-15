using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy.Compiler.Lexer
{
    public class SlidingTextWindow
    {
        public SlidingTextWindow(string text)
        {
            this.text = text;
            basis = 0;
            textEnd = text.Length;
            lexemeStart = 0;

            Offset = 0;
        }

        private const int DefaultWindowLength = 2048;
        private int lexemeStart;
        private int basis;
        private readonly int textEnd;
        private readonly string text;
        public int Offset { get; private set; }

        public void Start()
        {
            lexemeStart = Offset;
        }
    }
}
