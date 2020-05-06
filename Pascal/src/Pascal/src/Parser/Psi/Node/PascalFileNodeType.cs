using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node
{
    public class PascalFileNodeType : CompositeNodeType
    {
        public PascalFileNodeType(string s, int index) : base(s, index)
        {
        }


        public override CompositeElement Create()
        {
            return new PascalFile();
        }
    }
}