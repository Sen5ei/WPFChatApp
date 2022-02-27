﻿using System.Collections.Generic;

namespace WPFChatApp.Core
{
    /// <summary>
    /// The design-time data for a <see cref="SettingsViewModel"/>
    /// </summary>
    public class SettingsDesignModel : SettingsViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static SettingsDesignModel Instance => new SettingsDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SettingsDesignModel()
        {
            Name = new TextEntryViewModel { Label = "Name", OriginalText = "Ognjen Sredic" };
            Username = new TextEntryViewModel { Label = "Username", OriginalText = "ognjen" };
            Password = new TextEntryViewModel { Label = "Password", OriginalText = "********" };
            Email = new TextEntryViewModel { Label = "Email", OriginalText = "ognjensredic@gmail.com" };
        }

        #endregion
    }
}
