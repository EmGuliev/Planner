using System;
using System.Collections.Generic;
using System.Text;

namespace Planner.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string NoteName { get; set; }
        public string NoteText { get; set; }
        public string NoteDate { get; set; }
        public string NoteID { get; set; }
    }
}