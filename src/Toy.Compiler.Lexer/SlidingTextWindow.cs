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

        public int Offset { get; private set; }
        private const int DefaultWindowLength = 2048;
        private int lexemeStart;
        private int basis;
        private readonly int textEnd;
        private readonly string text;
        private char[] characterWindow = new char[DefaultWindowLength];

        public void Start()
        {
            lexemeStart = Offset;
        }

        public char PeekChar()
        {
            return characterWindow[Offset];
        }

        public void AdvanceChar()
        {
            Offset++;
        }

        /// <summary>
        /// The absolute position of the start of the current lexeme in the given
        /// SourceText.
        /// </summary>
        public int LexemeStartPosition
        {
            get
            {
                return basis + lexemeStart;
            }
        }

        public int Position
        {
            get
            {
                return basis + Offset;
            }
        }
    }
}
