using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalFunctionDesignator : PascalAntlrCompositeElement<GPascalParser.FunctionDesignatorContext>
    {
        public PascalFunctionDesignator(GPascalParser.FunctionDesignatorContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.FunctionDesignator;
    }
}