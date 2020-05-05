using System;
using JetBrains.Annotations;
using JetBrains.ReSharper.Plugins.Spring.Parser.Psi;
using JetBrains.ReSharper.Plugins.Spring.Utils;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve;
using JetBrains.ReSharper.Psi.Resolve;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Reference.Psi
{
    public class PascalVariableReference: TreeReferenceBase<PascalVariable>
    {
        private readonly PascalVariable _owner;
        
        public PascalVariableReference([NotNull] PascalVariable owner) : base(owner)
        {
            _owner = owner;
        }

        public override ResolveResultWithInfo ResolveWithoutCache()
        {
            Logger.Log("Requested resolve without a cache!");
            var file = _owner.GetContainingFile();
            if (file == null)
            {
                Logger.Log($"Did not find file for {_owner}");
                return ResolveResultWithInfo.Unresolved;
            }
            
            foreach (var descendant in file.Descendants())
            {
                if (descendant is PascalVariableDeclaration declaration)
                {
                    Logger.Log($"FOUND DECLARATION {descendant}. DECLARATION NAME {declaration.DeclaredName}, REFERENCE NAME {GetName()}");
                    if (declaration.DeclaredName == GetName())
                    {
                        return new ResolveResultWithInfo(new SimpleResolveResult(declaration.DeclaredElement), ResolveErrorType.OK);
                    }
                }
            }
            Logger.Log("Resolve did not succeed!");

            
            return ResolveResultWithInfo.Unresolved;
        }

        public override string GetName()
        {
            return myOwner.GetText().Trim('\r', '\n', '\t', ' ');
        }

        public override ISymbolTable GetReferenceSymbolTable(bool useReferenceName)
        {
            throw new NotImplementedException();
        }

        public override TreeTextRange GetTreeTextRange() => _owner.GetTreeTextRange();

        public override IReference BindTo(IDeclaredElement element)
        {
            ((PascalVariableDeclared) element).References.Add(this);
            return this;
        }

        //TODO-tanvd fix later
        public override IReference BindTo(IDeclaredElement element, ISubstitution substitution) => BindTo(element);

        //TODO check and fix
        public override IAccessContext GetAccessContext() => null;

        public override bool IsValid()
        {
            return myOwner.IsValid();
        }

        public PascalVariable Variable => _owner;
    }
}