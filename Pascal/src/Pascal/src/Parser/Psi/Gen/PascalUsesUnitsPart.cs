using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalUsesUnitsPart : PascalAntlrCompositeElement<GPascalParser.UsesUnitsPartContext>
    {
        public PascalUsesUnitsPart(GPascalParser.UsesUnitsPartContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.UsesUnitsPart;
    }
}