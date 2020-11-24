namespace Toy.Compiler.Lexer
{
    class SyntaxFacts
    {
        public static SyntaxKind GetKeywordKind(string text)
        {
            switch (text)
            {
                case "async":
                    return SyntaxKind.AsyncKeyword;
                case "await":
                    return SyntaxKind.AwaitKeyword;
                case "break":
                    return SyntaxKind.BreakKeyword;
                case "catch":
                    return SyntaxKind.CatchKeyword;
                case "class":
                    return SyntaxKind.ClassKeyword;
                case "const":
                    return SyntaxKind.ConstKeyword;
                case "continue":
                    return SyntaxKind.ContinueKeyword;
                case "default":
                    return SyntaxKind.DefaultKeyword;
                case "do":
                    return SyntaxKind.DoKeyword;
                case "else":
                    return SyntaxKind.ElseKeyword;
                case "false":
                    return SyntaxKind.FalseKeyword;
                case "finally":
                    return SyntaxKind.FinallyKeyword;
                case "for":
                    return SyntaxKind.ForKeyword;
                case "foreach":
                    return SyntaxKind.ForeachKeyword;
                case "get":
                    return SyntaxKind.GetKeyword;
                case "if":
                    return SyntaxKind.IfKeyword;
                case "in":
                    return SyntaxKind.InKeyword;
                case "interface":
                    return SyntaxKind.InterfaceKeyword;
                case "namespace":
                    return SyntaxKind.NamespaceKeyword;
                case "new":
                    return SyntaxKind.NewKeyword;
                case "null":
                    return SyntaxKind.NullKeyword;
                case "private":
                    return SyntaxKind.PrivateKeyword;
                case "public":
                    return SyntaxKind.PublicKeyword;
                case "readonly":
                    return SyntaxKind.ReadonlyKeyword;
                case "return":
                    return SyntaxKind.ReturnKeyword;
                case "set":
                    return SyntaxKind.SetKeyword;
                case "static":
                    return SyntaxKind.StaticKeyword;
                case "switch":
                    return SyntaxKind.SwitchKeyword;
                case "this":
                    return SyntaxKind.ThisKeyword;
                case "throw":
                    return SyntaxKind.ThrowKeyword;
                case "true":
                    return SyntaxKind.TrueKeyword;
                case "try":
                    return SyntaxKind.TryKeyword;
                case "typeof":
                    return SyntaxKind.TypeofKeyword;
                case "using":
                    return SyntaxKind.UsingKeyword;
                case "var":
                    return SyntaxKind.VarKeyword;
                case "void":
                    return SyntaxKind.VoidKeyword;
                case "while":
                    return SyntaxKind.WhileKeyword;
                default:
                    return SyntaxKind.None;
            }
        }
    }
}