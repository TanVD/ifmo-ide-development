using System;
using System.Collections.Generic;
using JetBrains.Application.Settings;
using JetBrains.ReSharper.Daemon.CSharp.Errors;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.I18n.Services.Daemon;
using JetBrains.ReSharper.Plugins.Spring.Lexer;
using JetBrains.ReSharper.Plugins.Spring.Utils;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Files;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Util;

namespace JetBrains.ReSharper.Plugins.Spring.Parser
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
                    if (treeNode is PsiBuilderErrorElement error)
                    {
                        var splits = error.ErrorDescription.Split('#');
                        
                        var message = splits[0];
                        var length = int.Parse(splits[1]);
                        
                        var range = error.GetDocumentRange().ExtendRight(length);
                        highlightings.Add( new HighlightingInfo(range, new CSharpSyntaxError(message, range)));
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