using System.Linq;
using System.Xml;
using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Plugins.Pascal.Resolve.Psi;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi
{
    public class PascalVariableDeclaration : PascalAntlrCompositeElement<GPascalParser.VariableDeclarationContext>, IDeclaration
    {
        public PascalIdentifier Identifier => this.Children().First(it => it is PascalIdentifier) as PascalIdentifier;

        public PascalVariableDeclaration(GPascalParser.VariableDeclarationContext context) : base(context)
        {
            DeclaredElement = new PascalVariableDeclared(this);
        }

        public override NodeType NodeType => PascalNodeTypes.VariableDeclaration;
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