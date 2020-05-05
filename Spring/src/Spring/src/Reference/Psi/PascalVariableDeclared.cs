using System.Collections.Generic;
using System.Xml;
using Antlr4.Runtime.Misc;
using JetBrains.ReSharper.Plugins.Spring.Parser.Psi;
using JetBrains.ReSharper.Plugins.Spring.Utils;
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

        public IList<IDeclaration> GetDeclarations()
        {
            PLogger.Info($"Someone requested declarations of variable  {_declaration}!");
            return new ArrayList<IDeclaration> {_declaration};
        }

        //TODO-tanvd fix -- working like there is only one file
        public IList<IDeclaration> GetDeclarationsIn(IPsiSourceFile sourceFile) => GetDeclarations();

        public DeclaredElementType GetElementType() => CLRDeclaredElementType.LOCAL_VARIABLE;
        public XmlNode GetXMLDoc(bool inherit) => null;

        public XmlNode GetXMLDescriptionSummary(bool inherit) => null;

        public bool IsValid() => true;

        public bool IsSynthetic() => false;

        public HybridCollection<IPsiSourceFile> GetSourceFiles()
        {
            PLogger.Info($"Someone requested GetSourceFiles of variable {_declaration.Identifier} at {_declaration.Identifier.IdentifierRange}!");
            PLogger.Info($"Its source file is {_declaration.GetSourceFile()}!");

            return new HybridCollection<IPsiSourceFile> {_declaration.GetSourceFile()};
        }

        //TODO-tanvd fix -- working like there is only one file and it is pascal
        public bool HasDeclarationsIn(IPsiSourceFile sourceFile)
        {
            PLogger.Info($"Someone requested HasDeclarationsIn of variable  {_declaration}!");
            PLogger.Info($"My answer is {sourceFile == _declaration.GetSourceFile()}!");

            return sourceFile == _declaration.GetSourceFile();
        }

        public string ShortName => _declaration.DeclaredName;
        public bool CaseSensitiveName => false;
        public PsiLanguageType PresentationLanguage => SpringLanguage.Instance;
    }
}