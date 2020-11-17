namespace Toy.Compiler.Lexer
{
    public enum SyntaxKind
    {
        None = 0,

        #region Reserved words

        AsyncKeyword,
        AwaitKeyword,
        BoolKeyword,
        BreakKeyword,
        CatchKeyword,
        CharKeyword,
        ClassKeyword,
        ConstKeyword,
        ContinueKeyword,
        DefaultKeyword,
        DoKeyword,
        DoubleKeyword,
        ElseKeyword,
        EnumKeyword,
        FalseKeyword,
        FinallyKeyword,
        FloatKeyword,
        ForKeyword,
        ForeachKeyword,
        GetKeyword,
        IfKeyword,
        InKeyword,
        IntKeyword,
        InterfaceKeyword,
        LongKeyword,
        NamespaceKeyword,
        NewKeyword,
        NullKeyword,
        ObjectKeyword,
        OutKeyword,
        PrivateKeyword,
        PublicKeyword,
        ReadonlyKeyword,
        RefKeyword,
        ReturnKeyword,
        SetKeyword,
        StaticKeyword,
        StringKeyword,
        StructKeyword,
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

        AmpersandToken,
        AsteriskToken,
        BackslashToken,
        BarToken,
        CaretToken,
        CloseBraceToken,
        CloseBracketToken,
        CloseParenToken,
        ColonToken,
        CommaToken,
        DollarToken,
        DotToken,
        DoubleQuoteToken,
        EqualsToken,
        ExclamationToken,
        GreaterThanToken,
        HashToken,
        LessThanToken,
        MinusToken,
        OpenBraceToken,
        OpenBracketToken,
        OpenParenToken,
        PercentToken,
        PlusToken,
        QuestionToken,
        SemicolonToken,
        SingleQuoteToken,
        SlashToken,
        TildeToken

        #endregion

        #region Compound punctuation

        #endregion

    }
}
