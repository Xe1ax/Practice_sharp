namespace Task_3
{
    internal class NoteBookPublisher
    {
        public NoteBookPublisher()
        {
        }

        internal void Publish(NoteBook noteBook)
        {
            Publish(noteBook.GetAll());
        }

        internal void Publish(List<Note> notes)
        {
            foreach (var note in notes)
            {
                Console.WriteLine(note);
            }
        }
    }
}