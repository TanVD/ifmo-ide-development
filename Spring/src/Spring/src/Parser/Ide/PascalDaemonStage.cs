using System;
using System.Collections.Generic;
using JetBrains.Application.Settings;
using JetBrains.ReSharper.Daemon.CSharp.Errors;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.I18n.Services.Daemon;
using JetBrains.ReSharper.Plugins.Spring.Parser.Psi;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Files;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Ide
{
    [DaemonStage]
    class PascalDaemonStage : DaemonStageBase<SpringFile>
    {
        protected override IDaemonStageProcess CreateDaemonProcess(
            IDaemonProcess process,
            DaemonProcessKind processKind,
            SpringFile file,
            IContextBoundSettingsStore settingsStore
        )
        {
            return new PascalDaemonProcess(process, file);
        }

        private class PascalDaemonProcess : IDaemonStageProcess
        {
            private readonly SpringFile _file;

            public PascalDaemonProcess(IDaemonProcess process, SpringFile file)
            {
                _file = file;
                DaemonProcess = process;
            }

            public void Execute(Action<DaemonStageResult> committer)
            {
                var highlightings = new List<HighlightingInfo>();
                foreach (var treeNode in _file.Descendants())
                {
                    if (treeNode is PascalErrorElement error)
                    {
                        var range = error.GetDocumentRange().ExtendRight(error.Length);
                        highlightings.Add( new HighlightingInfo(range, new CSharpSyntaxError(error.ErrorDescription, range)));
                    }
                }

                committer(new DaemonStageResult(highlightings));
            }

            public IDaemonProcess DaemonProcess { get; }
        }

        protected override IEnumerable<SpringFile> GetPsiFiles(IPsiSourceFile sourceFile)
        {
            yield return (SpringFile) sourceFile.GetDominantPsiFile<SpringLanguage>();
        }
    }
}