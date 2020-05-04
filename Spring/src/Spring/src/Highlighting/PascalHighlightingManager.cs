using JetBrains.ReSharper.Daemon.SyntaxHighlighting;
using JetBrains.ReSharper.Host.Features.SyntaxHighlighting;
using JetBrains.ReSharper.Plugins.Spring.Lexer;
using JetBrains.ReSharper.Psi;

namespace JetBrains.ReSharper.Plugins.Spring.Highlighting
{
    [Language(typeof(SpringLanguage))]
    internal class PascalHighlightingManager : RiderSyntaxHighlightingManager
    {
        public override SyntaxHighlightingProcessor CreateProcessor()
        {
            return new SyntaxHighlightingProcessor();
        }
    }
}