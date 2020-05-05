using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalFunctionDesignator : PascalAntlrCompositeElement<GPascalParser.FunctionDesignatorContext>
    {
        public PascalFunctionDesignator(GPascalParser.FunctionDesignatorContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.FunctionDesignator;
    }
}