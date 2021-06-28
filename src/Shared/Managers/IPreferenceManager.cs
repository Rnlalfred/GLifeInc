using GLifeInc.Shared.Settings;
using System.Threading.Tasks;
using GLifeInc.Shared.Wrapper;

namespace GLifeInc.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}