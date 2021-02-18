﻿using MattermostAddinConnect.Cache;
using MattermostAddinConnect.Settings;

namespace MattermostAddin
{
    public class ApplicationSettingsService : ISettingsLoadService, ISettingsSaveService
    {
        private readonly ICache _cache;

        public ApplicationSettingsService(ICache cache)
        {
            _cache = cache;
        }

        public AddInSettings Load()
        {
            return new AddInSettings(
                Properties.Settings.Default.MattermostUrl,
                Properties.Settings.Default.TeamId,
                Properties.Settings.Default.Username,
                Properties.Settings.Default.ChannelsMap,
                Properties.Settings.Default.Version);
        }

        public void SaveCredentials(string mattermostUrl, string teamId, string username, MattermostVersion version)
        {
            Properties.Settings.Default.MattermostUrl = mattermostUrl;
            Properties.Settings.Default.TeamId = teamId;
            Properties.Settings.Default.Username = username;
            Properties.Settings.Default.Version = version;
            Properties.Settings.Default.Save();
            _cache.Invalidate();
        }

        public void SaveChannels(string channelsMap)
        {
            Properties.Settings.Default.ChannelsMap = channelsMap;
            Properties.Settings.Default.Save();
        }
    }
}