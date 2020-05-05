using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalComponentType : PascalAntlrCompositeElement<GPascalParser.ComponentTypeContext>
    {
        public PascalComponentType(GPascalParser.ComponentTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ComponentType;
    }
}