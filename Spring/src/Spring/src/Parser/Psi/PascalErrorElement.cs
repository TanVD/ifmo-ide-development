using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi
{
    public class PascalErrorElement : CompositeElement, IErrorElement
    {
        public PascalErrorElement(string text, int length)
        {
            ErrorDescription = text;
            Length = length;
        }

        public override NodeType NodeType => PascalNodeTypes.Error;
        public override PsiLanguageType Language => SpringLanguage.Instance;
        public string ErrorDescription { get; }
        public int Length { get; }
    }
}