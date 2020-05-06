using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalBaseType : PascalAntlrCompositeElement<GPascalParser.BaseTypeContext>
    {
        public PascalBaseType(GPascalParser.BaseTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.BaseType;
    }
}