using Toy.Compiler.Lexer;

namespace Toy.Compiler.Parser
{
    class SyntaxTree
    {
        public void ParseText(string text)
        {
            var lexer = new LexicalAnalyzer(text);
            var parser = new SyntaxParser(lexer);
        }
    }
}
