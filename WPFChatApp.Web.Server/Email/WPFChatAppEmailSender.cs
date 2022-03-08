using System.Threading.Tasks;
using WPFChatApp.Core;
using static Dna.FrameworkDI;

namespace WPFChatApp.Web.Server
{
    /// <summary>
    /// Handles sending emails specific to the WPFChatApp server
    /// </summary>
    public static class WPFChatAppEmailSender
    {
        /// <summary>
        /// Sends a verification email to the specified user
        /// </summary>
        /// <param name="displayName">The users display name (typically first name)</param>
        /// <param name="email">The users email to be verified</param>
        /// <param name="verificationUrl">The URL the user needs to click to verify their email</param>
        /// <returns></returns>
        public static async Task<SendEmailResponse> SendUserVerificationEmailAsync(string displayName, string email, string verificationUrl)
        {
            return await DI.EmailTemplateSender.SendGeneralEmailAsync(new SendEmailDetails
            {
                IsHTML = true,
                FromEmail = Configuration["WPFChatAppSettings:SendEmailFromEmail"],
                FromName = Configuration["WPFChatAppSettings:SendEmailFromName"],
                ToEmail = email,
                ToName = displayName,
                Subject = "Verify Your Email - WPFChatApp"
            },
            "Verify Email",
            $"Hi {displayName ?? "stranger"},",
            "Thanks for creating an account with us.<br/>To continue please verify your email with us.",
            "Verify Email",
            verificationUrl
            );
        }
    }
}
