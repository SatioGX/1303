using System;

public class User
{
    public int ID;
    public string Name;
}

class Program
{
    static void Main(string[] args)
    {
        User[] users = new User[10];

        for (int i = 0; i < users.Length; i++)
        {
            users[i] = new User();
            users[i].ID = i + 1;
            users[i].Name = "placeholder" + (i + 1);
        }

        PrintUserArray(users);
    }

    static void PrintUserArray(User[] users)
    {
        for (int i = 0; i < users.Length; i++)
        {
            Console.WriteLine("User ID: " + users[i].ID + ", Name: " + users[i].Name);
        }
    }

    internal void TestReadLine()
    {
        throw new NotImplementedException();
    }
}