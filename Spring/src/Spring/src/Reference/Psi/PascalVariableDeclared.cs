using System.Collections.Generic;
using System.Xml;
using Antlr4.Runtime.Misc;
using JetBrains.ReSharper.Plugins.Spring.Parser.Psi;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Util.DataStructures;

namespace JetBrains.ReSharper.Plugins.Spring.Reference.Psi
{
    public class PascalVariableDeclared : IDeclaredElement
    {
        private readonly PascalVariableDeclaration _declaration;
        private readonly HashSet<PascalVariableReference> _references = new HashSet<PascalVariableReference>();

        public HashSet<PascalVariableReference> References => _references;

        public PascalVariableDeclared(PascalVariableDeclaration declaration, HashSet<PascalVariableReference> references = null)
        {
            if (references != null) _references = references;
            _declaration = declaration;
        }

        public IPsiServices GetPsiServices() => _declaration.GetPsiServices();

        public IList<IDeclaration> GetDeclarations() => new ArrayList<IDeclaration> {_declaration};

        //TODO-tanvd fix -- working like there is only one file
        public IList<IDeclaration> GetDeclarationsIn(IPsiSourceFile sourceFile) => GetDeclarations();

        public DeclaredElementType GetElementType() => CLRDeclaredElementType.LOCAL_VARIABLE;
        public XmlNode GetXMLDoc(bool inherit) => null;

        public XmlNode GetXMLDescriptionSummary(bool inherit) => null;

        public bool IsValid() => true;

        public bool IsSynthetic() => false;

        //TODO-tanvd would it even work?
        public HybridCollection<IPsiSourceFile> GetSourceFiles() => HybridCollection<IPsiSourceFile>.Empty;

        //TODO-tanvd fix -- working like there is only one file and it is pascal
        public bool HasDeclarationsIn(IPsiSourceFile sourceFile) => true;

        public string ShortName => _declaration.DeclaredName;
        public bool CaseSensitiveName => false;
        public PsiLanguageType PresentationLanguage => SpringLanguage.Instance;
    }
}