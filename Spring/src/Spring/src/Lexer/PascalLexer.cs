using Antlr4.Runtime;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;

namespace JetBrains.ReSharper.Plugins.Spring.Lexer
{
    internal class PascalLexer : ILexer<int>
    {
        private readonly pascalLexer _lexer;
        private IToken _curToken;
        private int _currentPosition;
        public IBuffer Buffer { get; }

        public PascalLexer(IBuffer buffer)
        {
            Buffer = buffer;
            _lexer = new pascalLexer(new AntlrInputStream(buffer.GetText()));
            _currentPosition = 0;
        }

        public void Start()
        {
            _curToken = _lexer.NextToken();
            _currentPosition++;
        }

        public void Advance()
        {
            _curToken = _lexer.NextToken();
            _currentPosition++;
        }

        public int CurrentPosition
        {
            get => _currentPosition;
            set
            {
                _lexer.Reset();
                int counter = 0;
                while (counter < value)
                {
                    _lexer.NextToken();
                    counter++;
                }

                _currentPosition = value;
            }
        }

        object ILexer.CurrentPosition
        {
            get => CurrentPosition;
            set => CurrentPosition = (int) value;
        }

        public TokenNodeType TokenType => SpringTokenType.Convert(_curToken.Type);
        public int TokenStart => _curToken.StartIndex;
        public int TokenEnd => _curToken.StopIndex;
    }
}