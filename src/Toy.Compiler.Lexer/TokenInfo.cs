namespace Toy.Compiler.Lexer
{
    class TokenInfo
    {
        public SyntaxKind Kind { get; set; }
        public string StringValue { get; set; }
        public char CharValue { get; set; }
        public int IntValue { get; set; }
        public long LongValue { get; set; }
        public float FloatValue { get; set; }
        public double DoubleValue { get; set; }
    }
}