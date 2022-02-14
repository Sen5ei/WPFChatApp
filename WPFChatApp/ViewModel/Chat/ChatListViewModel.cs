using System.Collections.Generic;

namespace WPFChatApp
{
    /// <summary>
    /// A view model fore the overview chat list
    /// </summary>
    public class ChatListViewModel : BaseViewModel
    {
        /// <summary>
        /// The chat list items for the list
        /// </summary>
        public List<ChatListItemViewModel> Items { get; set; }
    }
}
