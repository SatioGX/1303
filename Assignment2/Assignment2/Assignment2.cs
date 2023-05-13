class User
{
    public int ID { get; set; }
    public string Name { get; set; }
}

class Program
{
    static User[] users = new User[100];

    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Add user");
            Console.WriteLine("2 - Show user by ID");
            Console.WriteLine("3 - Show user by Name");
            Console.WriteLine("4 - Delete user by ID");
            Console.WriteLine("5 - Delete user by Name");
            Console.WriteLine("6 - List all users by Name");
            Console.WriteLine("0 - Exit");

            Console.Write("Enter your choice: ");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddUser();
                    break;
                case 2:
                    ShowUserByID();
                    break;
                case 3:
                    ShowUserByName();
                    break;
                case 4:
                    DeleteUserByID();
                    break;
                case 5:
                    DeleteUserByName();
                    break;
                case 6:
                    ListAllUsersByName();
                    break;
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 0);
    }

    static void AddUser()
    {
        Console.Write("Enter ID: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        User user = new User { ID = id, Name = name };
        int index = Array.FindIndex(users, u => u == null);
        if (index >= 0)
        {
            users[index] = user;
            Console.WriteLine("User added.");
        }
        else
        {
            Console.WriteLine("User array is full.");
        }
    }

    static void ShowUserByID()
    {
        Console.Write("Enter ID: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }

        User user = Array.Find(users, u => u?.ID == id);
        if (user != null)
        {
            Console.WriteLine($"ID: {user.ID}, Name: {user.Name}");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    static void ShowUserByName()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        User user = Array.Find(users, u => u?.Name == name);
        if (user != null)
        {
            Console.WriteLine($"ID: {user.ID}, Name: {user.Name}");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    static void DeleteUserByID()
    {
        Console.Write("Enter ID: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }

        int index = Array.FindIndex(users, u => u?.ID == id);
        if (index >= 0)
        {
            users[index] = null;
            Console.WriteLine("User deleted.");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    static void DeleteUserByName()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        int index = Array.FindIndex(users, u => u?.Name == name);
        if (index >= 0)
        {
            users[index] = null;
            Console.WriteLine("User deleted.");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    static void ListAllUsersByName()
    {
        Console.Write("Enter Name to filter (leave empty to list all users): ");
        string filter = Console.ReadLine();

        var filteredUsers = users.Where(u => u != null && (string.IsNullOrEmpty(filter) || u.Name.Contains(filter)));

        foreach (var user in filteredUsers)
        {
            Console.WriteLine($"ID: {user.ID}, Name: {user.Name}");
        }
    }
}
