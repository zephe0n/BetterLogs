﻿using Kingmaker.Localization;

namespace EnhancedCombatLogs
{
    internal static class Helpers
    {
        internal static LocalizedString CreateString(string key, string value)
        {
            var localizedString = new LocalizedString() { m_Key = key };
            LocalizationManager.CurrentPack.PutString(key, value);
            return localizedString;
        }
    }
}
