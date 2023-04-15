namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
           


            
            var noteBook = new NoteBook(NotesProvider.GetNotes());
            var noteBookService = new NoteBookService(noteBook);
            var noteBookPublisher = new NoteBookPublisher();
            while (true)
            {
                Console.WriteLine("Choose variant:");
                Console.WriteLine();
                Console.WriteLine("1.Add note");
                Console.WriteLine("2.Delete note");
                Console.WriteLine("3.Search note(s) by number");
                Console.WriteLine("4.Sort note(s) by fullName");
                Console.WriteLine("5.Show all notes");
                Console.WriteLine("6.Press CTRL+C to exit");
                int a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Note note = CreateNote();
                        noteBookService.Add(note);
                        noteBookPublisher.Publish(noteBook);
                        break;

                    case 2:
                        string phoneNumber = InputPhoneNuber();
                        noteBookService.Delete(phoneNumber);
                        noteBookPublisher.Publish(noteBook);

                        noteBookPublisher.Publish(noteBook);
                        break;

                    case 3:
                        string phoneNumberToSearch = InputPhoneNuber();

                        List<Note> notes = noteBookService.GetByNumber(phoneNumberToSearch);
                        if (notes != null)
                        {
                            noteBookPublisher.Publish(notes);

                        }
                        break;
                    case 4:
                        List<Note> orderedNotes = noteBookService.GetAll()
                                                                 .OrderBy(note => note.FullName, StringComparer.OrdinalIgnoreCase)
                                                                 .ToList();
                        noteBookPublisher.Publish(orderedNotes);
                        break;
                    case 5:
                        
                            noteBookPublisher.Publish(noteBook);
                        break;
                    default: Console.WriteLine("Uncorrect input. "); break;
                }
            }
        
        }

        private static string InputPhoneNuber()
        {
            bool isValid = false;
            var validPhoneNumber = default(string);
            while (!isValid)
            {
                Console.WriteLine("Try Enter phone number example : +375(29)1234567");
                var input=Console.ReadLine();
              
                    if (PhoneValidator.Validate(input))
                    {
                        validPhoneNumber = input;
                    isValid=true;
                    }      
                    else {
                    Console.WriteLine("Input not a phone number");
                }

            }
            return validPhoneNumber;

        }

        private static Note CreateNote()
        {
            var note = new Note();
            Console.WriteLine("Enter full name");
            note.FullName = Console.ReadLine();

            Console.WriteLine("Enter birth date (dd/mm/yyyy)");
            note.BirthDate =DateOnly.Parse( Console.ReadLine());   
            
            Console.WriteLine("Enter phone Number");
            note.PhoneNumber =InputPhoneNuber();
            return note;

        }
    }
}
