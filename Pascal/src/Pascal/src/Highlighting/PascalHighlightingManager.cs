using JetBrains.ReSharper.Daemon.SyntaxHighlighting;
using JetBrains.ReSharper.Host.Features.SyntaxHighlighting;
using JetBrains.ReSharper.Psi;

namespace JetBrains.ReSharper.Plugins.Pascal.Highlighting
{
    [Language(typeof(PascalLanguage))]
    internal class PascalHighlightingManager : RiderSyntaxHighlightingManager
    {
        public override SyntaxHighlightingProcessor CreateProcessor()
        {
            return new SyntaxHighlightingProcessor();
        }
    }
}