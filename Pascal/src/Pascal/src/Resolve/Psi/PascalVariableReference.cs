using System.Collections.Generic;
using JetBrains.Annotations;
using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi;
using JetBrains.ReSharper.Plugins.Pascal.Utils;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve;
using JetBrains.ReSharper.Psi.Impl.Resolve;
using JetBrains.ReSharper.Psi.Resolve;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Resolve.Psi
{
    public class PascalVariableReference : TreeReferenceBase<PascalVariable>, ICompletableReference
    {
        private readonly PascalVariable _owner;

        public PascalVariableReference([NotNull] PascalVariable owner) : base(owner)
        {
            _owner = owner;
        }

        public override ResolveResultWithInfo ResolveWithoutCache()
        {
            var file = _owner.GetContainingFile();
            if (file == null)
            {
                return ResolveResultWithInfo.Unresolved;
            }

            foreach (var descendant in file.Descendants())
            {
                if (descendant is PascalVariableDeclaration declaration)
                {
                    if (declaration.DeclaredName == GetName())
                    {
                        return new ResolveResultWithInfo(new SimpleResolveResult(declaration.DeclaredElement), ResolveErrorType.OK);
                    }
                }
            }

            return ResolveResultWithInfo.Unresolved;
        }

        public override string GetName() => _owner.Identifier.Name;

        public override ISymbolTable GetReferenceSymbolTable(bool useReferenceName)
        {
            var file = _owner.GetContainingFile();
            if (file == null)
            {
                return EmptySymbolTable.INSTANCE;
            }


            var elements = new HashSet<PascalVariableDeclared>();
            foreach (var descendant in file.Descendants())
            {
                if (descendant is PascalVariableDeclaration declaration)
                {
                    if (!useReferenceName || declaration.DeclaredName == GetName())
                    {
                        PLogger.Info($"Adding to table {declaration}");
                        elements.Add((PascalVariableDeclared) declaration.DeclaredElement);
                    }
                }
            }

            var table = new DeclaredElementsSymbolTable<PascalVariableDeclared>(_owner.GetPsiServices(), elements);

            return table;
        }

        public override TreeTextRange GetTreeTextRange()
        {
            return _owner.Identifier.IdentifierRange;
        }

        public override IReference BindTo(IDeclaredElement element)
        {
            ((PascalVariableDeclared) element).References.Add(this);
            return this;
        }

        public override IReference BindTo(IDeclaredElement element, ISubstitution substitution) => BindTo(element);

        public override IAccessContext GetAccessContext() => new DefaultAccessContext(_owner);

        public override bool IsValid()
        {
            return myOwner.IsValid();
        }

        //TODO-tanvd For some reason does not work
        public ISymbolTable GetCompletionSymbolTable()
        {
            PLogger.Info("Requested completion symbol table");
            return GetReferenceSymbolTable(false);
        }
    }
}