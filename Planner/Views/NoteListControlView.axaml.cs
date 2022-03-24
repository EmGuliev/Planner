using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Planner.Models;
using System.Collections.Generic;

namespace Planner.Views
{
    public partial class NoteListControlView : UserControl
    {
        public NoteListControlView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
