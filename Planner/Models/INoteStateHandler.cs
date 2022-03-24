using System.Collections.ObjectModel;

namespace Planner.Models
{
    interface INoteStateHandler
    {
        public void AddNewNoteToFile(string Date, string Name, string Text, int ID);
        public void GetAllNotes(string Date, ObservableCollection<NoteState> ListForWriting);
    }
}
