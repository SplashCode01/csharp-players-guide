using System.Runtime.CompilerServices;

namespace TheLockedDoor;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Welcome to DoorMaker2000. Enter a passcode to make a door: ");
        Door door = new Door(Console.ReadLine());

        while (true)
        {
            DoorPrompt(door);
        }

        Console.ReadKey();
    }

    public static void DoorPrompt(Door door)
    {
        Console.WriteLine($"The door is currently {door.State}. What would you like to do?");
        Console.WriteLine("1. Open the door");
        Console.WriteLine("2. Close the door");
        Console.WriteLine("3. Lock the door");
        Console.WriteLine("4. Unlock the door");
        Console.WriteLine("5. Change the passcode");
        Console.WriteLine("6. Exit");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                door.Open();
                break;
            case "2":
                door.Close();
                break;
            case "3":
                door.Lock();
                break;
            case "4":
                Console.Write("Enter the passcode to unlock the door: ");
                string code = Console.ReadLine();
                door.Unlock(code);
                break;
            case "5":
                Console.Write("Enter the old passcode: ");
                string oldPasscode = Console.ReadLine();
                Console.Write("Enter the new passcode: ");
                string newPasscode = Console.ReadLine();
                if (door.ChangePasscode(oldPasscode, newPasscode)) Console.WriteLine("Passcode change successful.");
                else Console.WriteLine("Incorrect password.");
                break;
            case "6":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    public class Door
    {
        public DoorState State { get; private set; }
        private string passcode;

        public Door(string passcode)
        {
            this.passcode = passcode;
            State = DoorState.Closed;
        }

        public bool ChangePasscode(string oldPasscode, string newPasscode)
        {
            if (passcode == oldPasscode)
            {
                passcode = newPasscode;
                return true;
            }

            return false;
        }

        public void Close()
        {
            if (State == DoorState.Open) State = DoorState.Closed;
        }

        public void Open()
        {
            if (State == DoorState.Closed) State = DoorState.Open;
        }

        public void Lock()
        {
            if (State == DoorState.Closed) State = DoorState.Locked;
        }

        public void Unlock(string code)
        {
            if (State == DoorState.Locked && passcode == code) State = DoorState.Closed;
            Console.WriteLine("Wrong Passcode.");
        }
    }

    public enum DoorState { Open, Closed, Locked };
}
