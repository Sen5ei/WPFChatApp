using Dna;
using Microsoft.Extensions.DependencyInjection;
using WPFChatApp.Core;

namespace WPFChatApp
{
    /// <summary>
    /// Extension methods for the <see cref="FrameworkConstruction"/>
    /// </summary>
    public static class FrameworkConstructionExtensions
    {
        /// <summary>
        /// Injects the view models needed for WPFChatApp application
        /// </summary>
        /// <param name="construction"></param>
        /// <returns></returns>
        public static FrameworkConstruction AddWPFChatAppViewModels(this FrameworkConstruction construction)
        {
            // Bind to a single instance of Application view model
            construction.Services.AddSingleton<ApplicationViewModel>();

            // Bind to a single instance of Settings view model
            construction.Services.AddSingleton<SettingsViewModel>();

            // Return the construction for chaining
            return construction;
        }

        /// <summary>
        /// Injects the WPFChatApp client application services needed for the WPFChatApp application
        /// </summary>
        /// <param name="construction"></param>
        /// <returns></returns>
        public static FrameworkConstruction AddWPFChatAppClientServices(this FrameworkConstruction construction)
        {
            // Add our task manager
            construction.Services.AddTransient<ITaskManager, BaseTaskManager>();

            // Bind a file manager
            construction.Services.AddTransient<IFileManager, BaseFileManager>();

            // Bind a UI Manager
            construction.Services.AddTransient<IUIManager, UIManager>();

            // Return the construction for chaining
            return construction;
        }
    }
}
