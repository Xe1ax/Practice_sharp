namespace Task_3
{
    class MenuItem
    {
        public string Title { get; set; }
        public List<MenuItem> SubMenu { get; set; }

        public MenuItem(string title)
        {
            Title = title;
            SubMenu = new List<MenuItem>();
        }
    }

    class Menu
    {
        public List<MenuItem> Items { get; set; }

        public Menu()
        {
            Items = new List<MenuItem>();
        }

        public void AddMenuItem(string title, Menu subMenu = null)
        {
            var menuItem = new MenuItem(title);

            if (subMenu != null)
            {
                menuItem.SubMenu = subMenu.Items;
            }

            Items.Add(menuItem);
        }

        public Menu Clone()
        {
            var newMenu = new Menu();

            foreach (var item in Items)
            {
                newMenu.Items.Add(CloneMenuItem(item));
            }

            return newMenu;
        }

        private MenuItem CloneMenuItem(MenuItem item)
        {
            var newItem = new MenuItem(item.Title);

            foreach (var subItem in item.SubMenu)
            {
                newItem.SubMenu.Add(CloneMenuItem(subItem));
            }

            return newItem;
        }

        public void PrintMenu(List<MenuItem> menuItems)
        {
            foreach (var item in menuItems)
            {
                Console.WriteLine(item.Title);

                if (item.SubMenu.Count > 0)
                {
                    PrintMenu(item.SubMenu);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            menu.AddMenuItem("Item 1");
            menu.AddMenuItem("Item 2");
            var subMenu = new Menu();
            subMenu.AddMenuItem("Sub Item 1");
            subMenu.AddMenuItem("Sub Item 2");
            menu.AddMenuItem("Item 3", subMenu);

            Console.WriteLine("Original menu:");
            menu.PrintMenu(menu.Items);

            var menuCopy = menu.Clone();

            Console.WriteLine("Copied menu:");
            menuCopy.PrintMenu(menuCopy.Items);
        }
    }
}