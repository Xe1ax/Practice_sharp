using System.Collections;

namespace Task_4
{
    public class Song
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public Song(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }
    }

    public class CD
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public ArrayList Songs { get; set; }

        public CD(string title, string artist, int year)
        {
            Title = title;
            Artist = artist;
            Year = year;
            Songs = new ArrayList();
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void RemoveSong(Song song)
        {
            Songs.Remove(song);
        }

        public override string ToString()
        {
            string result = $"CD: {Title} ({Artist}, {Year})\n";
            foreach (Song song in Songs)
            {
                result += $"  {song.Name} ({song.Duration} sec)\n";
            }
            return result;
        }
    }

    public class Catalog
    {
        private Hashtable CDs { get; set; }

        public Catalog()
        {
            CDs = new Hashtable();
        }

        public void AddCD(CD cd)
        {
            CDs.Add(cd.Title, cd);
        }

        public void RemoveCD(string title)
        {
            CDs.Remove(title);
        }

        public override string ToString()
        {
            string result = "";
            foreach (CD cd in CDs.Values)
            {
                result += cd.ToString() + "\n";
            }
            return result;
        }

        public string GetCD(string title)
        {
            if (CDs.ContainsKey(title))
            {
                CD cd = (CD)CDs[title];
                return cd.ToString();
            }
            else
            {
                return "CD not found.";
            }
        }
    }
    class Disk
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public List<string> Songs { get; set; }

        public Disk(string title, string artist)
        {
            Title = title;
            Artist = artist;
            Songs = new List<string>();
        }

        public override string ToString()
        {
            return $"{Title} by {Artist}";
        }
    }

    class MusicCatalog
    {
        private Dictionary<string, Disk> _catalog;

        public MusicCatalog()
        {
            _catalog = new Dictionary<string, Disk>();
        }

        public void AddDisk(string title, string artist)
        {
            Disk disk = new Disk(title, artist);
            _catalog[title] = disk;
        }

        public void AddSong(string diskTitle, string songTitle)
        {
            if (!_catalog.ContainsKey(diskTitle))
            {
                Console.WriteLine($"Error: Disk {diskTitle} not found in catalog");
                return;
            }

            Disk disk = _catalog[diskTitle];
            disk.Songs.Add(songTitle);
        }

        public void RemoveDisk(string title)
        {
            if (!_catalog.ContainsKey(title))
            {
                Console.WriteLine($"Error: Disk {title} not found in catalog");
                return;
            }

            _catalog.Remove(title);
        }

        public void RemoveSong(string diskTitle, string songTitle)
        {
            if (!_catalog.ContainsKey(diskTitle))
            {
                Console.WriteLine($"Error: Disk {diskTitle} not found in catalog");
                return;
            }

            Disk disk = _catalog[diskTitle];
            if (!disk.Songs.Contains(songTitle))
            {
                Console.WriteLine($"Error: Song {songTitle} not found on disk {diskTitle}");
                return;
            }

            disk.Songs.Remove(songTitle);
        }

        public void ListCatalog()
        {
            foreach (KeyValuePair<string, Disk> entry in _catalog)
            {
                Console.WriteLine(entry.Value);
                foreach (string song in entry.Value.Songs)
                {
                    Console.WriteLine($"- {song}");
                }
            }
        }

        public void ListDisk(string title)
        {
            if (!_catalog.ContainsKey(title))
            {
                Console.WriteLine($"Error: Disk {title} not found in catalog");
                return;
            }

            Disk disk = _catalog[title];
            Console.WriteLine(disk);
            foreach (string song in disk.Songs)
            {
                Console.WriteLine($"- {song}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MusicCatalog catalog = new MusicCatalog();

            catalog.AddDisk("The White Album", "The Beatles");
            catalog.AddSong("The White Album", "Back in the U.S.S.R.");
            catalog.AddSong("The White Album", "Dear Prudence");
            catalog.AddSong("The White Album", "Glass Onion");

            catalog.AddDisk("Thriller", "Michael Jackson");
            catalog.AddSong("Thriller", "Beat It");
            catalog.AddSong("Thriller", "Thriller");
            catalog.AddSong("Thriller", "Billie Jean");

            catalog.ListCatalog();

            Console.WriteLine();
            catalog.RemoveSong("Thriller", "Beat It");
            catalog.ListCatalog();

            Console.WriteLine();
            catalog.RemoveDisk("The White Album");
            catalog.ListCatalog();

            Console.WriteLine();
            catalog.ListDisk("Thriller");
        }
    }
}