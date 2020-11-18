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

        private void ScanSyntaxToken()
        {
            var info = new TokenInfo();
            var character = TextWindow.PeekChar();
            switch (character)
            {
                case '\"':
                case '\'':
                    // TODO: Scan string literal
                    break;

                case '&':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.AmpersandToken;
                    break;
                case '*':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.AsteriskToken;
                    break;
                case '\\':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.BackslashToken;
                    break;
                case '|':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.BarToken;
                    break;
                case '^':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.CaretToken;
                    break;
                case '}':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.CloseBraceToken;
                    break;
                case ']':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.CloseBracketToken;
                    break;
                case ':':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.ColonToken;
                    break;
                case ',':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.CommaToken;
                    break;
                case '$':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.DollarToken;
                    break;
                case '.':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.DotToken;
                    break;
                case '=':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.EqualsToken;
                    break;
                case '!':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.ExclamationToken;
                    break;
                case '>':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.GreaterThanToken;
                    break;
                case '#':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.HashToken;
                    break;
                case '<':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.LessThanToken;
                    break;
                case '-':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.MinusToken;
                    break;
                case '{':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.OpenBraceToken;
                    break;
                case '[':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.OpenBracketToken;
                    break;
                case '(':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.OpenParenToken;
                    break;
                case '%':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.PercentToken;
                    break;
                case '+':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.PlusToken;
                    break;
                case '?':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.QuestionToken;
                    break;
                case ';':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.SemicolonToken;
                    break;
                case '/':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.SlashToken;
                    break;
                case '~':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.TildeToken;
                    break;
            }
        }
    }
}
