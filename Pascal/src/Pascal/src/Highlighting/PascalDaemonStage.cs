using System;
using System.Collections.Generic;
using JetBrains.Application.Settings;
using JetBrains.ReSharper.Daemon.CSharp.Errors;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.I18n.Services.Daemon;
using JetBrains.ReSharper.Plugins.Pascal.Lexer;
using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi;
using JetBrains.ReSharper.Plugins.Pascal.Resolve;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Files;
using JetBrains.ReSharper.Psi.Resolve;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Highlighting
{
    [DaemonStage]
    class PascalDaemonStage : DaemonStageBase<PascalFile>
    {
        protected override IDaemonStageProcess CreateDaemonProcess(
            IDaemonProcess process,
            DaemonProcessKind processKind,
            PascalFile file,
            IContextBoundSettingsStore settingsStore
        )
        {
            return new PascalDaemonProcess(process, file);
        }

        private class PascalDaemonProcess : IDaemonStageProcess
        {
            private readonly PascalFile _file;
            private readonly PascalReferenceFactory _referenceFactory = new PascalReferenceFactory();

            public PascalDaemonProcess(IDaemonProcess process, PascalFile file)
            {
                _file = file;
                DaemonProcess = process;
            }

            public void Execute(Action<DaemonStageResult> committer)
            {
                var highlightings = new List<HighlightingInfo>();
                //Lexer check
                foreach (var treeNode in _file.Descendants())
                {
                    if (treeNode is PascalErrorElement error)
                    {
                        var range = error.GetDocumentRange().ExtendRight(error.Length);
                        highlightings.Add(new HighlightingInfo(range, new CSharpSyntaxError(error.ErrorDescription, range)));
                    }
                    else if (treeNode is PascalLeafToken unknown && unknown.NodeType == PascalTokenTypes.UNKNOWN)
                    {
                        var range = unknown.GetDocumentRange();
                        highlightings.Add(new HighlightingInfo(range, new CSharpSyntaxError("Unexpected symbols", range)));
                    }
                }

                //Resolution check
                foreach (var treeNode in _file.Descendants())
                {
                    var references = _referenceFactory.GetReferences(treeNode, ReferenceCollection.Empty);
                    if (references.Any(it => it.Resolve().Info.ResolveErrorType != ResolveErrorType.OK))
                    {
                        var range = references.First().GetDocumentRange();
                        highlightings.Add(new HighlightingInfo(range, new CSharpSyntaxError("Symbol cannot be resolved", range)));
                    }
                }

                committer(new DaemonStageResult(highlightings));
            }

            public IDaemonProcess DaemonProcess { get; }
        }

        protected override IEnumerable<PascalFile> GetPsiFiles(IPsiSourceFile sourceFile)
        {
            yield return (PascalFile) sourceFile.GetDominantPsiFile<PascalLanguage>();
        }
    }
}