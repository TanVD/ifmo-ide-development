using Antlr4.Runtime;
using JetBrains.ReSharper.Plugins.Spring.Utils;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;

namespace JetBrains.ReSharper.Plugins.Spring.Lexer
{
    public class PascalLexer : ILexer<int>
    {
        private readonly GPascalLexer _lexer;

        private bool _isStarted;

        private IToken _curToken;

        private int _currentPosition;
        public IBuffer Buffer { get; }

        public PascalLexer(IBuffer buffer)
        {
            Buffer = buffer;
            _lexer = new GPascalLexer(new AntlrInputStream(buffer.GetText()));
            _currentPosition = 0;
        }

        public void Start()
        {
            _curToken = _lexer.NextToken();
            _currentPosition++;
            _isStarted = true;
        }

        public void Advance()
        {
            if (!_isStarted)
            {
                Start();
                _isStarted = true;
                return;
            }

            _curToken = _lexer.NextToken();
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

        public TokenNodeType TokenType => _curToken.Type == -1 ? null : PascalTokenTypes.Convert(_curToken.Type);

        public int TokenStart
        {
            get
            {
                var startIndex = _curToken.StartIndex;
                Logger.Log($"Start index is {startIndex}");
                return startIndex;
            }
        }

        public int TokenEnd
        {
            get
            {
                var stopIndex = _curToken.StopIndex + 1;
                Logger.Log($"End index is {stopIndex}");
                return stopIndex;
            }
        }
    }
}