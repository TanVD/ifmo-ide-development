using System.Collections.Generic;
using JetBrains.Annotations;
using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi;
using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen;
using JetBrains.ReSharper.Plugins.Pascal.Resolve.Psi;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Util;

namespace JetBrains.ReSharper.Plugins.Pascal.Resolve.Util
{
    public static class PascalPsiUtil
    {
        [CanBeNull]
        public static PascalBlock FindBlock(ITreeNode from)
        {
            var cur = from;
            while (cur != null && !(cur is PascalBlock))
            {
                cur = cur.Parent;
            }

            return cur as PascalBlock;
        }

        [NotNull]
        public static IEnumerable<IDeclaredElement> FindDeclarations(ITreeNode from)
        {
            var block = FindBlock(from);
            if (block == null) return EmptyList<PascalVariableDeclared>.Instance;

            var result = new HashSet<IDeclaredElement>();
            foreach (var child in block.Descendants())
            {
                if (child is PascalVariableDeclaration declaration)
                {
                    result.Add(declaration.DeclaredElement);
                }
            }

            return result;
        }
    }
}