using System;
using System.Collections.Generic;
using System.Text;

namespace Toy.Compiler.Lexer
{
    public class LexicalAnalyzer
    {
        public LexicalAnalyzer(string text)
        {
            TextWindow = new SlidingTextWindow(text);
            builder = new StringBuilder();
        }

        private List<Exception> errors;
        private readonly StringBuilder builder;
        public SlidingTextWindow TextWindow { get; private set; }
        public bool HasErrors { get { return errors != null; } }

        public void Start()
        {
            TextWindow.Start();
            errors = null;
        }

        private void ScanSyntaxToken(TokenInfo info)
        {
            var character = TextWindow.PeekChar();
            switch (character)
            {
                case '"':
                case '\'':
                    this.ScanStringLiteral(info);
                    break;
                #region Punctuation

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

                #endregion

                #region Identifier and Keyword

                case 'a':
                case 'b':
                case 'c':
                case 'd':
                case 'e':
                case 'f':
                case 'g':
                case 'h':
                case 'i':
                case 'j':
                case 'k':
                case 'l':
                case 'm':
                case 'n':
                case 'o':
                case 'p':
                case 'q':
                case 'r':
                case 's':
                case 't':
                case 'u':
                case 'v':
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                case 'G':
                case 'H':
                case 'I':
                case 'J':
                case 'K':
                case 'L':
                case 'M':
                case 'N':
                case 'O':
                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                case 'T':
                case 'U':
                case 'V':
                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                case '_':
                    ScanIdentifierOrKeyword(info);
                    break;

                #endregion

                #region Numeric

                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    ScanNumericLiteral(info);
                    break;

                    #endregion
            }
        }

        private void ScanStringLiteral(TokenInfo info)
        {
            builder.Clear();
            var quoteCharacter = TextWindow.PeekChar();
            TextWindow.AdvanceChar();

            while (true)
            {
                var ch = TextWindow.PeekChar();
                if (ch == quoteCharacter)
                {
                    TextWindow.AdvanceChar();
                    break;
                }
                else if (ch == '\\')
                {
                    ch = ScanEscapeSequence();
                    builder.Append(ch);
                }
                else
                {
                    TextWindow.AdvanceChar();
                    builder.Append(ch);
                }
            }

            if (quoteCharacter == '\'')
            {
                info.Kind = SyntaxKind.CharacterLiteralToken;
                info.CharValue = builder[0];
            }
            else
            {
                info.Kind = SyntaxKind.StringLiteralToken;
                info.StringValue = builder.ToString();
            }
        }

        private void ScanIdentifierOrKeyword(TokenInfo info)
        {

        }

        private void ScanNumericLiteral(TokenInfo info)
        {
            builder.Clear();

            while (true)
            {
                var ch = TextWindow.PeekChar();
                if (!(ch >= '0' && ch <= '9'))
                {
                    break;
                }
                TextWindow.AdvanceChar();
                builder.Append(ch);
            }
            info.IntValue = Int32.Parse(builder.ToString());
            info.Kind = SyntaxKind.NumericLiteralToken;
        }

        private char ScanEscapeSequence()
        {
            var start = TextWindow.Position;
            TextWindow.AdvanceChar();
            var ch = TextWindow.PeekChar();
            switch (ch)
            {
                case '\'':
                case '\"':
                case '\\':
                    break;
                case 'a':
                    ch = '\u0007';
                    break;
                case 'b':
                    ch = '\u0008';
                    break;
                case 'f':
                    ch = '\u000c';
                    break;
                case 'n':
                    ch = '\u000a';
                    break;
                case 'r':
                    ch = '\u000d';
                    break;
                case 't':
                    ch = '\u0009';
                    break;
                case 'v':
                    ch = '\u000b';
                    break;
                case '0':
                    ch = '\u0000';
                    break;
                default:
                    throw new Exception();
            }

            return ch;
        }
    }
}
