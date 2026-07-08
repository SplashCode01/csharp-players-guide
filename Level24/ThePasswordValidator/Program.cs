namespace ThePasswordValidator;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter a password to validate (or type 'exit' to quit): ");
            string? password = Console.ReadLine();

            if (password == null || password == "exit") Environment.Exit(0);

            if (PasswordValidator.IsValid(password)) Console.WriteLine("That password is valid.");
            else Console.WriteLine("That password is not valid.");
        }
    }

    public static class PasswordValidator
    {
        public static bool IsValid(string password)
        {
            if (password.Length > 13 || password.Length < 6) return false;
            if (!HasUppercase(password)) return false;
            if (!HasLowercase(password)) return false;
            if (!HasDigit(password)) return false;
            if (Contains(password, 'T')) return false;
            if (Contains(password, '%')) return false;

            return true;
        }

        private static bool HasUppercase(string password)
        {
            foreach (char c in password)
            {
                if (char.IsUpper(c)) return true;
            }
            return false;
        }

        private static bool HasLowercase(string password)
        {
            foreach (char c in password)
            {
                if (char.IsLower(c)) return true;
            }
            return false;
        }

        private static bool HasDigit(string password)
        {
            foreach (char c in password)
            {
                if (char.IsDigit(c)) return true;
            }
            return false;
        }

        private static bool Contains(string password, char letter)
        {
            foreach (char c in password)
            {
                if (c == letter) return true;
            }
            return false;
        }
    }
}
