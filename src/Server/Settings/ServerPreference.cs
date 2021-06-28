using System.Linq;
using GLifeInc.Shared.Constants.Localization;
using GLifeInc.Shared.Settings;

namespace GLifeInc.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}