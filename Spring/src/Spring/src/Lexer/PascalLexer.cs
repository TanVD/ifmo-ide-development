using Antlr4.Runtime;
using JetBrains.ReSharper.Plugins.Spring.Utils;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;

namespace JetBrains.ReSharper.Plugins.Spring.Lexer.Lexer
{
    internal class PascalLexer : ILexer<int>
    {
        private readonly pascalLexer _lexer;

        private bool _isWhitespace = false;
        
        private IToken _prevToken;
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
            if (_isWhitespace)
            {
                _isWhitespace = false;
            }
            else
            {
                _prevToken = _curToken;
                _curToken = _lexer.NextToken();
                if (_prevToken != null && _prevToken.StopIndex + 1 != _curToken.StartIndex)
                {
                    _isWhitespace = true;
                }
            }
            _currentPosition++;
        }

        public int CurrentPosition
        {
            get => _currentPosition;
            set
            {
                _lexer.Reset();
                var counter = 0;
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

        public TokenNodeType TokenType
        {
            get
            {
                if (_isWhitespace)
                {
                    return PascalTokenTypes.WS;
                }

                if (_curToken.Type == -1)
                {
                    return null;
                }

                return PascalTokenTypes.Convert(_curToken.Type);
            }
        }

        public int TokenStart
        {
            get
            {
                var startIndex = _isWhitespace ? _prevToken.StopIndex + 1 : _curToken.StartIndex;
                Logger.Log($"Start index is {startIndex}");
                return startIndex;
            }
        }

        public int TokenEnd
        {
            get
            {
                var stopIndex = _isWhitespace ? _curToken.StartIndex : _curToken.StopIndex + 1;
                Logger.Log($"End index is {stopIndex}");
                return stopIndex;
            }
        }
    }
}
