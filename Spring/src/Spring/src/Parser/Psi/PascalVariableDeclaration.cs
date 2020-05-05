using System.Xml;
using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Plugins.Spring.Reference.Psi;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi
{
    public class PascalVariableDeclaration : CompositeElement, IDeclaration
    {
        public override NodeType NodeType => PascalCompositeNodeTypes.VariableDeclaration;
        public override PsiLanguageType Language => SpringLanguage.Instance;
        public XmlNode GetXMLDoc(bool inherit) => null;

        public void SetName(string name)
        {
        }

        public TreeTextRange GetNameRange() => FirstChild.GetTreeTextRange();
        public bool IsSynthetic() => false;

        public IDeclaredElement DeclaredElement => new PascalVariableDeclared(this);
        public string DeclaredName
        {
            get
            {
                var text = GetText();
                var splitted = text.Split(':');
                return splitted[0].Trim('\r', '\n', '\t', ' ');
            }
        }
    }
}