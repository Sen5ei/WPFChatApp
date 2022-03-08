using System.Windows.Controls;
using static WPFChatApp.DI;

namespace WPFChatApp
{
    /// <summary>
    /// Interaction logic for SettingsControl.xaml
    /// </summary>
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();

            // Set data context to settings view model
            DataContext = ViewModelSettings;
        }
    }
}
