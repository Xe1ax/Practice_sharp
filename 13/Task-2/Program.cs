namespace Task_2
{
        internal class Program
        {
            static void Main(string[] args)
            {

                var info = new MyInfo();
                info.NameChanged += name => Console.WriteLine($"Имя изменено на {name}");
                info.Name = "Иван";
                info.Name = "Петр";
            }
            public class MyInfo
            {
                private string _name;

                public event Action<string> NameChanged;

                public string Name
                {
                    get { return _name; }
                    set
                    {
                        if (_name != value)
                        {
                            _name = value;
                            OnNameChanged(_name);
                        }
                    }
                }

                protected virtual void OnNameChanged(string newName)
                {
                    NameChanged?.Invoke(newName);
                }
            }
        }
    }