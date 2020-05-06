using JetBrains.Application;
using JetBrains.Application.Settings;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings;
using JetBrains.ReSharper.Psi;

namespace JetBrains.ReSharper.Plugins.Pascal.IntelliSense
{
    [ShellComponent]
    public class PascalIntelliSenseManager : LanguageSpecificIntellisenseManager
    {
        public PascalIntelliSenseManager(ISettingsStore settingsStore)
            : base(settingsStore)
        {
        }

        public override SettingsScalarEntry GetSettingsEntry()
        {
            return SettingsStore.Schema.GetScalarEntry((IntelliSenseEnabledCssSettingsKey setting) => setting.IntelliSenseEnabled);
        }

        public override PsiLanguageType PsiLanguage => PascalLanguage.Instance;

        public class IntelliSenseEnabledCssSettingsKey
        {
            [SettingsEntry(false, "Pascal (.ps files)")]
            public bool IntelliSenseEnabled;
        }
    }
}