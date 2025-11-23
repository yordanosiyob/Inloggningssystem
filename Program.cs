using System;

class Program
{
    static void Main()
    {
        // Arrayer för användarnamn och lösenord
        string[] usernames = new string[100];  // maximalt 100 användare
        string[] passwords = new string[100];
        int userCount = 0;

        Console.WriteLine("Välkommen till inloggningssidan");

        bool running = true;
        while (running)
        {
            // Huvudmeny
            Console.WriteLine("Välj en åtgärd:");
            Console.WriteLine("1. Sign in");
            Console.WriteLine("2. Log in");
            Console.WriteLine("3. Avsluta");
            Console.Write("Ange ditt val: ");
            string choice = Console.ReadLine();

            if (choice == "1") // Sign in
            {
                Console.WriteLine("== Sign In ==");
                Console.Write("Ange ett användarnamn: ");
                string newUsername = Console.ReadLine();

                Console.Write("Ange ett lösenord: ");
                string newPassword = Console.ReadLine();

                usernames[userCount] = newUsername;
                passwords[userCount] = newPassword;
                userCount++;

                Console.WriteLine("Du har skapat ett konto. Gå tillbaka till huvudmenyn för att logga in.");
            }
            else if (choice == "2") // Log in
            {
                Console.WriteLine("== Log In ==");
                Console.Write("Användarnamn: ");
                string loginUsername = Console.ReadLine();

                Console.Write("Lösenord: ");
                string loginPassword = Console.ReadLine();

                bool success = false;

                for (int i = 0; i < userCount; i++)
                {
                    if (usernames[i] == loginUsername & passwords[i] == loginPassword)
                    {
                        success = true;
                        break;
                    }
                }

                if (success)
                {
                    Console.WriteLine("Inloggning lyckades!");
                }
                else
                {
                    Console.WriteLine("Inloggningen misslyckades. Försök igen.");
                }
            }
            else if (choice == "3") // Avsluta
            {
                running = false;
                Console.WriteLine("Programmet avslutas.");
            }
            else
            {
                Console.WriteLine("Ogiltigt val. Försök igen.");
            }
        }
    }
}



    