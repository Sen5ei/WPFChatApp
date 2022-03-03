using Microsoft.Extensions.DependencyInjection;
using System;

namespace WPFChatApp.Web.Server
{
    /// <summary>
    /// A shorthand access class to get DI services with nice clean short code
    /// </summary>
    public static class IoC
    {
        /// <summary>
        /// The scoped instance of hte <see cref="ApplicationDbContext"/>
        /// </summary>
        public static ApplicationDbContext ApplicationDbContext => IocContainer.Provider.GetService<ApplicationDbContext>();
    }

    /// <summary>
    /// The dependency injection container making use of the built in .Net Core service provider
    /// </summary>
    public static class IocContainer
    {
        /// <summary>
        /// The service provider for this application
        /// </summary>
        public static IServiceProvider Provider { get; set; }
    }
}
