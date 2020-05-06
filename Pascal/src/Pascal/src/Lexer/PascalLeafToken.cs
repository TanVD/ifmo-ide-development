using System.Text;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;

namespace JetBrains.ReSharper.Plugins.Spring.Lexer
{
    internal class PascalLeafToken : LeafElementBase, ITokenNode
    {
        private readonly string _text;
        private readonly PascalTokenType _type;

        public PascalLeafToken(string text, PascalTokenType tokenType)
        {
            _text = text;
            _type = tokenType;
        }

        public override int GetTextLength() => _text.Length;

        public override string GetText() => _text;

        public override StringBuilder GetText(StringBuilder to)
        {
            to.Append(GetText());
            return to;
        }

        public override IBuffer GetTextAsBuffer() => new StringBuffer(GetText());

        public override string ToString() => base.ToString() + $"(type: {_type}, Text: {_text})";

        public override NodeType NodeType => _type;
        public override PsiLanguageType Language => PascalLanguage.Instance;

        public TokenNodeType GetTokenType()
        {
            return _type;
        }
    }
}