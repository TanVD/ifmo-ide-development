using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalFileType : PascalAntlrCompositeElement<GPascalParser.FileTypeContext>
    {
        public PascalFileType(GPascalParser.FileTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.FileType;
    }
}