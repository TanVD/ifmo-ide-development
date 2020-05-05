using Antlr4.Runtime.Misc;
using JetBrains.DataFlow;
using JetBrains.Lifetimes;
using JetBrains.ReSharper.Plugins.Spring.Lexer;
using JetBrains.ReSharper.Plugins.Spring.Parser.Psi;
using JetBrains.ReSharper.Plugins.Spring.Reference.Psi;
using JetBrains.ReSharper.Plugins.Spring.Utils;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Caches;
using JetBrains.ReSharper.Psi.Resolve;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Reference
{
    [ReferenceProviderFactory]
    public class PascalReferenceProvider : IReferenceProviderFactory
    {
        public PascalReferenceProvider(Lifetime lifetime)
        {
            Changed = new Signal<IReferenceProviderFactory>(lifetime, GetType().FullName);
        }

        public IReferenceFactory CreateFactory(IPsiSourceFile sourceFile, IFile file, IWordIndex wordIndexForChecks)
        {
            if (sourceFile.LanguageType.Name == ((PsiLanguageType) SpringLanguage.Instance).Name)
            {
                PLogger.Info($"Got factory for pascal references");
                return new PascalReferenceFactory();
            }

            return null;
        }

        public ISignal<IReferenceProviderFactory> Changed { get; }
    }

    public class PascalReferenceFactory : IReferenceFactory
    {
        public ReferenceCollection GetReferences(ITreeNode element, ReferenceCollection oldReferences)
        {
            PLogger.Info($"Requested references for {element} with parent {element.Parent}");
 
            if (element is PascalVariable variable)
            {
                PLogger.Info($"Element was variable!");
                return new ReferenceCollection(new ArrayList<IReference> {new PascalVariableReference(variable)});
            }

            return ReferenceCollection.Empty;
        }

        public bool HasReference(ITreeNode element, IReferenceNameContainer names)
        {
            if (element is PascalVariable variable)
            {
                var name = variable.GetText();
                return names.Contains(name);
            }

            return false;
        }
    }
}