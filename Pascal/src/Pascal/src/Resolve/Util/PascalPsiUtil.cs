using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using JetBrains.Platform.MsBuildTask.Utils;
using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.PsiGen.Util;

namespace JetBrains.ReSharper.Plugins.Pascal.Resolve.Util
{
    public static class PascalPsiUtil
    {
        public static ITreeNode FindNearestDeclarationRoot(this ITreeNode from)
        {
            var cur = from;
            while (cur != null && !(cur is PascalBlock) && !(cur is PascalProcedureDeclaration) && !(cur is PascalFunctionDeclaration))
            {
                cur = cur.Parent;
            }

            return cur;
        }

        [NotNull]
        public static IEnumerable<IDeclaration> FindAllAccessibleDeclarations(ITreeNode from)
        {
            var result = new HashSet<IDeclaration>();
            var root = from.FindNearestDeclarationRoot();

            while (root != null)
            {
                result.addAll(root.GetDeclarationsFromRoot());
                root = root.Parent?.FindNearestDeclarationRoot();
            }

            return result;
        }

        [NotNull]
        public static IEnumerable<IDeclaredElement> FindAllAccessibleDeclared(ITreeNode from)
        {
            var declarations = FindAllAccessibleDeclarations(from);
            return from declaration in declarations select declaration.DeclaredElement;
        }

        public static IEnumerable<IDeclaration> GetDeclarationsFromRoot(this ITreeNode from)
        {
            if (from is PascalBlock)
            {
                return from.Children().Where(it => it is PascalVariableDeclarationPart).TryGetSingleItem()?.GetDeclarationsInDescendants() ?? Enumerable.Empty<IDeclaration>();
            }

            if (from is PascalProcedureDeclaration || from is PascalFunctionDeclaration)
            {
                return from.Children().Where(it => it is PascalFormalParameterList).TryGetSingleItem()?.GetDeclarationsInDescendants() ?? Enumerable.Empty<IDeclaration>();
            }

            return Enumerable.Empty<IDeclaration>();
        }


        private static IEnumerable<IDeclaration> GetDeclarationsInDescendants(this ITreeNode from)
        {
            var result = new HashSet<IDeclaration>();
            foreach (var child in from.Descendants())
            {
                if (child is IDeclaration declaration)
                {
                    result.Add(declaration);
                }
            }

            return result;
        }
    }
}