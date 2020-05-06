using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi
{
    public class PascalErrorElement : CompositeElement, IErrorElement
    {
        public PascalErrorElement(string text, int length)
        {
            ErrorDescription = text;
            Length = length;
        }

        public override NodeType NodeType => PascalNodeTypes.Error;
        public override PsiLanguageType Language => PascalLanguage.Instance;
        public string ErrorDescription { get; }
        public int Length { get; }
    }
}