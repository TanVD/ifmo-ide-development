using System;
using JetBrains.Annotations;
using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi;
using JetBrains.ReSharper.Plugins.Pascal.Resolve.Util;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve;
using JetBrains.ReSharper.Psi.Resolve;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Resolve.Psi
{
    public class PascalVariableReference : TreeReferenceBase<PascalVariable>
    {
        private readonly PascalVariable _owner;

        public PascalVariableReference([NotNull] PascalVariable owner) : base(owner)
        {
            _owner = owner;
        }

        public override ResolveResultWithInfo ResolveWithoutCache()
        {
            var file = _owner.GetContainingFile();
            if (file == null) return ResolveResultWithInfo.Unresolved;

            foreach (var descendant in PascalPsiUtil.FindAllAccessibleDeclarations(_owner))
            {
                if (descendant is IDeclaration declaration && declaration.DeclaredName == GetName())
                {
                    return new ResolveResultWithInfo(new SimpleResolveResult(declaration.DeclaredElement), ResolveErrorType.OK);
                }
            }

            return ResolveResultWithInfo.Unresolved;
        }

        public override string GetName() => _owner.Identifier.Name;

        public override ISymbolTable GetReferenceSymbolTable(bool useReferenceName)
        {
            throw new NotImplementedException();
        }

        public override TreeTextRange GetTreeTextRange()
        {
            return _owner.Identifier.IdentifierRange;
        }

        public override IReference BindTo(IDeclaredElement element) => this;

        public override IReference BindTo(IDeclaredElement element, ISubstitution substitution) => this;

        public override IAccessContext GetAccessContext() => new DefaultAccessContext(_owner);

        public override bool IsValid()
        {
            return myOwner.IsValid();
        }
    }
}