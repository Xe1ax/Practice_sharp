namespace Task_3
{
    internal class NotesProvider
    {
        internal static List<Note> GetNotes()
        {
            return new List<Note> {
            new Note()
            {
                FullName= "Sauron",
                BirthDate=DateOnly.FromDateTime(DateTime.Now),
                PhoneNumber="+375(25)7654321"
            },
                new Note()
            {
                FullName= "Pavel Lord",
                BirthDate=DateOnly.FromDateTime(DateTime.Now),
                PhoneNumber="+375(29)1234567"
            },
                new Note()
            {
                FullName= "Donald Trump",
                BirthDate=DateOnly.FromDateTime(DateTime.Now),
                PhoneNumber="+375(33)9876543"
            },

            };
        }
    }
}