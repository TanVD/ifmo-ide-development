using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using JetBrains.Util;

namespace JetBrains.ReSharper.Plugins.Spring.Lexer
{
    public class PascalTokenType : TokenNodeType
    {
        public PascalTokenType(string s, int index) : base(s, index)
        {
            PascalTokenTypes.Register(this);
        }

        public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
        {
            return new PascalLeafToken(buffer.GetText(new TextRange(startOffset.Offset, endOffset.Offset)), this);
        }

        public override bool IsWhitespace => this == PascalTokenTypes.WS;
        public override bool IsComment => this == PascalTokenTypes.COMMENT_1 || this == PascalTokenTypes.COMMENT_2;

        public override bool IsStringLiteral =>
            this == PascalTokenTypes.STRING || this == PascalTokenTypes.STRING_LITERAL;

        public override bool IsConstantLiteral => PascalTokenTypes.Constants.Contains(this);
        public override bool IsIdentifier => this == PascalTokenTypes.IDENT || this == PascalTokenTypes.LABEL;
        public override bool IsKeyword => PascalTokenTypes.Keywords.Contains(this);

        public override string TokenRepresentation { get; }
    }
}