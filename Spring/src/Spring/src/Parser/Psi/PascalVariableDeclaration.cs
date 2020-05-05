using System.Linq;
using System.Xml;
using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Plugins.Spring.Reference.Psi;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi
{
    public class PascalVariableDeclaration : PascalAntlrCompositeElement<GPascalParser.VariableDeclarationContext>, IDeclaration
    {
        public PascalIdentifier Identifier => this.Children().First(it => it is PascalIdentifier) as PascalIdentifier;

        public PascalVariableDeclaration(GPascalParser.VariableDeclarationContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.VariableDeclaration;
        public XmlNode GetXMLDoc(bool inherit) => null;

        public void SetName(string name)
        {
        }

        public TreeTextRange GetNameRange() => Identifier.GetTreeTextRange();
        public bool IsSynthetic() => false;

        public IDeclaredElement DeclaredElement => new PascalVariableDeclared(this);

        public string DeclaredName => Identifier.Name;
    }
}