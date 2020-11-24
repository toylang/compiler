namespace Toy.Compiler.Lexer
{
    public enum SyntaxKind
    {
        None = 0,

        #region Reserved words

        AsyncKeyword,
        AwaitKeyword,
        BreakKeyword,
        CatchKeyword,
        ClassKeyword,
        ConstKeyword,
        ContinueKeyword,
        DefaultKeyword,
        DoKeyword,
        ElseKeyword,
        FalseKeyword,
        FinallyKeyword,
        ForKeyword,
        ForeachKeyword,
        GetKeyword,
        IfKeyword,
        InKeyword,
        InterfaceKeyword,
        NamespaceKeyword,
        NewKeyword,
        NullKeyword,
        PrivateKeyword,
        PublicKeyword,
        ReadonlyKeyword,
        ReturnKeyword,
        SetKeyword,
        StaticKeyword,
        SwitchKeyword,
        ThisKeyword,
        ThrowKeyword,
        TrueKeyword,
        TryKeyword,
        TypeofKeyword,
        UsingKeyword,
        VarKeyword,
        VoidKeyword,
        WhileKeyword,
        #endregion

        #region  Contextual keywords

        #endregion

        #region Punctuation

        /// <summary>Represents <c>&amp;</c> token.</summary>
        AmpersandToken,
        /// <summary>Represents <c>*</c> token.</summary>
        AsteriskToken,
        /// <summary>Represents <c>\</c> token.</summary>
        BackslashToken,
        /// <summary>Represents <c>|</c> token.</summary>
        BarToken,
        /// <summary>Represents <c>^</c> token.</summary>
        CaretToken,
        /// <summary>Represents <c>}</c> token.</summary>
        CloseBraceToken,
        /// <summary>Represents <c>]</c> token.</summary>
        CloseBracketToken,
        /// <summary>Represents <c>)</c> token.</summary>
        CloseParenToken,
        /// <summary>Represents <c>:</c> token.</summary>
        ColonToken,
        /// <summary>Represents <c>,</c> token.</summary>
        CommaToken,
        /// <summary>Represents <c>$</c> token.</summary>
        DollarToken,
        /// <summary>Represents <c>.</c> token.</summary>
        DotToken,
        /// <summary>Represents <c>"</c> token.</summary>
        DoubleQuoteToken,
        /// <summary>Represents <c>=</c> token.</summary>
        EqualsToken,
        /// <summary>Represents <c>!</c> token.</summary>
        ExclamationToken,
        /// <summary>Represents <c>&gt;</c> token.</summary>
        GreaterThanToken,
        /// <summary>Represents <c>#</c> token.</summary>
        HashToken,
        /// <summary>Represents <c>&lt;</c> token.</summary>
        LessThanToken,
        /// <summary>Represents <c>-</c> token.</summary>
        MinusToken,
        /// <summary>Represents <c>{</c> token.</summary>
        OpenBraceToken,
        /// <summary>Represents <c>[</c> token.</summary>
        OpenBracketToken,
        /// <summary>Represents <c>(</c> token.</summary>
        OpenParenToken,
        /// <summary>Represents <c>%</c> token.</summary>
        PercentToken,
        /// <summary>Represents <c>+</c> token.</summary>
        PlusToken,
        /// <summary>Represents <c>?</c> token.</summary>
        QuestionToken,
        /// <summary>Represents <c>;</c> token.</summary>
        SemicolonToken,
        /// <summary>Represents <c>'</c> token.</summary>
        SingleQuoteToken,
        /// <summary>Represents <c>/</c> token.</summary>
        SlashToken,
        /// <summary>Represents <c>~</c> token.</summary>
        TildeToken,

        #endregion

        #region Compound punctuation

        #endregion

        #region Text

        CharacterLiteralToken,
        NumericLiteralToken,
        StringLiteralToken,

        #endregion

        #region Other

        EndOfFileToken,

        #endregion
    }
}
