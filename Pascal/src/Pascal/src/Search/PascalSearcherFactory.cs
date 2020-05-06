using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.ReSharper.Plugins.Spring.Resolve;
using JetBrains.ReSharper.Plugins.Spring.Resolve.Psi;
using JetBrains.ReSharper.Plugins.Spring.Utils;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Finder;
using JetBrains.ReSharper.Psi.Files;
using JetBrains.ReSharper.Psi.Resolve;
using JetBrains.ReSharper.Psi.Search;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Search
{
    [PsiSharedComponent]
    public class PascalSearcherFactory : DomainSpecificSearcherFactoryBase
    {
        private readonly SearchDomainFactory _searchDomainFactory;

        public PascalSearcherFactory(SearchDomainFactory searchDomainFactory)
        {
            _searchDomainFactory = searchDomainFactory;
        }

        public override bool IsCompatibleWithLanguage(PsiLanguageType languageType)
        {
            return languageType.Is<PascalLanguage>();
        }

        public override IDomainSpecificSearcher CreateReferenceSearcher(IDeclaredElementsSet elements, bool findCandidates)
        {
            return new ReferenceSearcher(elements, findCandidates);
        }

        public override IEnumerable<string> GetAllPossibleWordsInFile(IDeclaredElement element)
        {
            return new HashSet<string> {element.ShortName};
        }

        public override ISearchDomain GetDeclaredElementSearchDomain(IDeclaredElement declaredElement)
        {
            if (declaredElement is PascalVariableDeclared)
            {
                return _searchDomainFactory.CreateSearchDomain(declaredElement.GetSourceFiles());
            }

            PLogger.Info("Not PascalVariableDeclared!");

            return base.GetDeclaredElementSearchDomain(declaredElement);
        }

        public override Tuple<ICollection<IDeclaredElement>, bool> GetNavigateToTargets(IDeclaredElement element)
        {
            return CreateTarget(element);
        }

        private static Tuple<ICollection<IDeclaredElement>, bool> CreateTarget(IDeclaredElement element)
        {
            return new Tuple<ICollection<IDeclaredElement>, bool>(new[] {element}, false);
        }

        private class ReferenceSearcher : IDomainSpecificSearcher
        {
            private readonly PascalReferenceFactory _referenceFactory = new PascalReferenceFactory();

            private readonly IDeclaredElementsSet _elements;
            private readonly bool _findCandidate;

            public ReferenceSearcher(IDeclaredElementsSet elements, bool findCandidates)
            {
                _elements = elements;
                _findCandidate = findCandidates;
            }

            public bool ProcessProjectItem<TResult>(IPsiSourceFile sourceFile, IFindResultConsumer<TResult> consumer)
            {
                return sourceFile.GetPsiFiles<PascalLanguage>().Any(file => ProcessElement(file, consumer));
            }

            public bool ProcessElement<TResult>(ITreeNode element, IFindResultConsumer<TResult> consumer)
            {
                var referenceNames = new HashSet<string>();

                var references = _referenceFactory.GetReferences(element, ReferenceCollection.Empty);
                foreach (var reference in references)
                {
                    var resolve = reference.Resolve();
                    if (resolve.Info.ResolveErrorType == ResolveErrorType.OK && _elements.Contains(resolve.Result.DeclaredElement))
                    {
                        referenceNames.Add(reference.GetName());
                    }
                }

                var result = new Processor<TResult>(element, _findCandidate, consumer, _elements, referenceNames).Run();

                return result == FindExecution.Stop;
            }

            private class Processor<TResult> : ReferenceSearchSourceFileProcessor<TResult>
            {
                public Processor(
                    ITreeNode treeNode, bool findCandidates, IFindResultConsumer<TResult> resultConsumer,
                    IDeclaredElementsSet elements, ICollection<string> referenceNames
                )
                    : base(treeNode, findCandidates, resultConsumer, elements, referenceNames, referenceNames)
                {
                }

                protected override bool AcceptElement(IDeclaredElement resolvedElement)
                {
                    return Elements.Contains(resolvedElement);
                }
            }
        }
    }
}