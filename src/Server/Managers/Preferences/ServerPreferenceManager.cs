﻿using System.Collections.Generic;
using System.Threading.Tasks;
using GLifeInc.Application.Interfaces.Services.Storage;
using GLifeInc.Server.Settings;
using GLifeInc.Shared.Constants.Storage;
using GLifeInc.Shared.Settings;
using GLifeInc.Shared.Wrapper;
using Microsoft.Extensions.Localization;

namespace GLifeInc.Server.Managers.Preferences
{
    public class ServerPreferenceManager : IServerPreferenceManager
    {
        private readonly IServerStorageService _serverStorageService;
        private readonly IStringLocalizer<ServerPreferenceManager> _localizer;

        public ServerPreferenceManager(
            IServerStorageService serverStorageService,
            IStringLocalizer<ServerPreferenceManager> localizer)
        {
            _serverStorageService = serverStorageService;
            _localizer = localizer;
        }

        public async Task<IResult> ChangeLanguageAsync(string languageCode)
        {
            var preference = await GetPreference() as ServerPreference;
            if (preference != null)
            {
                preference.LanguageCode = languageCode;
                await SetPreference(preference);
                return new Result
                {
                    Succeeded = true,
                    Messages = new List<string> { _localizer["Server Language has been changed"] }
                };
            }

            return new Result
            {
                Succeeded = false,
                Messages = new List<string> { _localizer["Failed to get server preferences"] }
            };
        }

        public async Task<IPreference> GetPreference()
        {
            return await _serverStorageService.GetItemAsync<ServerPreference>(StorageConstants.Server.Preference) ?? new ServerPreference();
        }

        public async Task SetPreference(IPreference preference)
        {
            await _serverStorageService.SetItemAsync(StorageConstants.Server.Preference, preference as ServerPreference);
        }
    }
}