using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Planner.Views
{
    public partial class AddView : UserControl
    {
        public AddView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
