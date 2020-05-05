using Antlr4.Runtime;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi
{
    public abstract class PascalAntlrCompositeElement<T> : CompositeElement where T : RuleContext
    {
        public PascalAntlrCompositeElement(T context)
        {
            Context = context;
        }

        public T Context { get; set; }

        public override PsiLanguageType Language => SpringLanguage.Instance;
    }
}