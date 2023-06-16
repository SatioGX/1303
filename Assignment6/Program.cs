using Assignment6;

public class Program
{
    public delegate void DisplayDelegate(User user);

    public static void Display(List<User> users, DisplayDelegate displayDelegate)
    {
        foreach (var user in users)
        {
            displayDelegate(user);
        }
    }

    public static void Main()
    {
        var users = new List<User>();

        for (int i = 1; i <= 5; i++)
        {
            var regularUser = new RegularUser
            {
                Name = $"RegularUser{i}",
                Username = $"regularuser{i}",
                Email = $"regularuser{i}@example.com"
            };

            users.Add(regularUser);
        }

        for (int i = 1; i <= 5; i++)
        {
            var eliteUser = new EliteUser
            {
                Name = $"EliteUser{i}",
                Username = $"eliteuser{i}",
                Email = $"eliteuser{i}@example.com"
            };

            users.Add(eliteUser);
        }

        DisplayDelegate displayDelegate = DisplayUserProperties;

        Display(users, displayDelegate);
    }

    public static void DisplayUserProperties(User user)
    {
        Console.WriteLine($"Name: {user.Name}");
        Console.WriteLine($"Username: {user.Username}");
        Console.WriteLine($"Email: {user.Email}");
        Console.WriteLine();
    }
}