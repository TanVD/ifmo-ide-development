using System.Linq;
using System.Xml;
using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Plugins.Pascal.Resolve.Psi;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi
{
    public class PascalParameterDeclaration : PascalAntlrCompositeElement<GPascalParser.ParameterGroupContext>, IDeclaration
    {
        public PascalIdentifier Identifier => this.Children().First(it => it is PascalIdentifier) as PascalIdentifier;
        
        public PascalParameterDeclaration(GPascalParser.ParameterGroupContext context) : base(context)
        {
            DeclaredElement = new PascalParameterDeclared(this);
        }

        public override NodeType NodeType => PascalNodeTypes.ParameterGroup;
        public XmlNode GetXMLDoc(bool inherit) => null;

        public void SetName(string name)
        {
        }

        public TreeTextRange GetNameRange() => Identifier.IdentifierRange;

        public bool IsSynthetic() => false;

        public IDeclaredElement DeclaredElement { get; }
        public string DeclaredName => Identifier.Name;
    }
}