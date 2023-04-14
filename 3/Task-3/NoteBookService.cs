namespace Task_3
{
    internal class NoteBookService
    {
        private NoteBook noteBook;

        public NoteBookService(NoteBook noteBook)
        {
            this.noteBook = noteBook;
        }

        internal void Add(Note note)
        {
            noteBook.Add(note);
        }

        internal void Delete(string phoneNumber)
        {
            noteBook.Delete(phoneNumber);
        }

        internal List<Note> GetAll()
        {
           return noteBook.GetAll();
        }

        internal List<Note> GetByNumber(string phoneNumberToSearch)
        {
          return  noteBook.GetAll().Where(note=>note.PhoneNumber==phoneNumberToSearch).ToList();
        }
    }
}