namespace Task_3
{
    internal class NoteBook
    {
        private List<Note> _notes;

        public NoteBook(List<Note> notes)
        {
            this._notes = notes;
        }

        public NoteBook()
        {
            _notes= new List<Note>(0);
        }

        internal void Add(Note note)
        {
            _notes.Add(note);
        }

        internal bool Delete(string phoneNumber)
        {
            var foundNotes= _notes.Where(note=>note.PhoneNumber==phoneNumber).ToList();
            if (foundNotes.Count==0)
            {
                return false;
            }
            foreach (var note in foundNotes)
            {
                _notes.Remove(note);
            }
            return true;
        }

        internal List<Note> GetAll()
        {
            return _notes;
        }
    }
}