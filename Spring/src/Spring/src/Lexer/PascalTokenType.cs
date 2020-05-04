using System.Collections.Generic;
using System.Text;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using JetBrains.Util;
using JetBrains.Util.Collections;

namespace JetBrains.ReSharper.Plugins.Spring.Lexer
{
    public class PascalTokenType : TokenNodeType
    {
        public PascalTokenType(string s, int index) : base(s, index)
        {
        }


        private class PascalGenericToken : LeafElementBase, ITokenNode
        {
            private readonly string _myText;
            private readonly PascalTokenType _myType;

            public PascalGenericToken(string text, PascalTokenType tokenType)
            {
                _myText = text;
                _myType = tokenType;
            }

            public override int GetTextLength()
            {
                return _myText.Length;
            }

            public override string GetText()
            {
                return _myText;
            }

            public override StringBuilder GetText(StringBuilder to)
            {
                to.Append(GetText());
                return to;
            }

            public override IBuffer GetTextAsBuffer()
            {
                return new StringBuffer(GetText());
            }

            public override string ToString()
            {
                return base.ToString() + "(type:" + _myType + ", text:" + _myText + ")";
            }

            public override NodeType NodeType => _myType;
            public override PsiLanguageType Language => SpringLanguage.Instance;

            public TokenNodeType GetTokenType()
            {
                return _myType;
            }
        }

        public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
        {
            return new PascalGenericToken(buffer.GetText(new TextRange(startOffset.Offset, endOffset.Offset)), this);
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