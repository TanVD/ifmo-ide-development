using System.Collections.Generic;
using System.Xml;
using Antlr4.Runtime.Misc;
using ICSharpCode.NRefactory;
using JetBrains.ReSharper.Plugins.Spring.Parser.Psi;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Util.DataStructures;

namespace JetBrains.ReSharper.Plugins.Spring.Resolve.Psi
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

        public IList<IDeclaration> GetDeclarations()
        {
            return new ArrayList<IDeclaration> {_declaration};
        }

        //TODO-tanvd fix -- working like there is only one file
        public IList<IDeclaration> GetDeclarationsIn(IPsiSourceFile sourceFile)
        {
            var file = _declaration.GetSourceFile();
            if (file != null && file.Equals(sourceFile))
            {
                return new ArrayList<IDeclaration> {_declaration};
            }

            return EmptyList<IDeclaration>.Instance;
        }

        public DeclaredElementType GetElementType() => CLRDeclaredElementType.FIELD;
        public XmlNode GetXMLDoc(bool inherit) => null;

        public XmlNode GetXMLDescriptionSummary(bool inherit) => null;

        public bool IsValid() => _declaration.IsValid();

        public bool IsSynthetic() => false;

        public HybridCollection<IPsiSourceFile> GetSourceFiles()
        {
            var file = _declaration.GetSourceFile();
            if (file == null)
            {
                return HybridCollection<IPsiSourceFile>.Empty;
            }

            return new HybridCollection<IPsiSourceFile>(file);
        }

        //TODO-tanvd fix -- working like there is only one file and it is pascal
        public bool HasDeclarationsIn(IPsiSourceFile sourceFile)
        {
            return sourceFile.Equals(_declaration.GetSourceFile());
        }

        public string ShortName => _declaration.DeclaredName;
        public bool CaseSensitiveName => false;
        public PsiLanguageType PresentationLanguage => PascalLanguage.Instance;
    }
}