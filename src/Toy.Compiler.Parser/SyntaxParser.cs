using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toy.Compiler.Lexer;

namespace Toy.Compiler.Parser
{
    public class SyntaxParser
    {
        public SyntaxParser(LexicalAnalyzer lexer)
        {
            this.lexer = lexer;
        }

        private readonly LexicalAnalyzer lexer;
    }
}
