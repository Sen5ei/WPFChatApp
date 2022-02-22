using System.Collections.Generic;

namespace WPFChatApp.Core
{
    /// <summary>
    /// A view model fore a chat messgae thread list
    /// </summary>
    public class ChatMessageListViewModel : BaseViewModel
    {
        /// <summary>
        /// The chat thread items for the list
        /// </summary>
        public List<ChatMessageListItemViewModel> Items { get; set; }
    }
}
