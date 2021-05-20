using System;
using System.Collections.Generic;
using System.Threading;
using c_sharp_intro.Models;
// NOTE Equivalent to 'IMPORT" lines
// NOTE All Methods and Properties are written in PascalCase, while local variables are written with camelCase

namespace c_sharp_intro
// SECTION 
{
    class Program
    {
        // SECTION Variable Declaration: Implicit & Explicit
        //      IMPLICIT: Type is implied by the assigned value
        //          var x = "Sam";  <-- NOTE Semicolon is required at the end of EVERY declaration
        //          x = 7;  <-- NOTE This will FAIL because 'x' has been previously declared as a String

        //      EXPLICIT: 
        //          string name = "Sam";
        //          string name = 6;  <-- NOTE This will FAIL because it was pre-defined as a String
        //          int myNum;  <-- NOTE Explicit Declarations can be made without assigning an initial value
        static void Main(string[] args)
        // NOTE When C# runs, it looks for this 'MAIN' method first and foremost
        {
            // SECTION Number Game!
            // Console.WriteLine("Do you want to play a game? (Y/N)");
            // char choice = Console.ReadKey().KeyChar;
            // Console.WriteLine("");
            // // Adds a line between the typed character and Console response
            // if (choice == 'y')
            // {
            //     Console.WriteLine("Let's Play!");

            // }
            // else if (choice == 'n')
            // {
            //     Console.WriteLine("Too Bad!  Let's Play!");
            // }
            // else
            // {
            //     Console.WriteLine("Your stupidity is upsetting, let's play anyway!");
            // }
            // bool running = true;
            // while (running)
            // {
            //     Console.Write("Calculating random number.");
            //     int freq = 150;
            //     for (int i = 0; i < 6; i++)
            //     {
            //         Thread.Sleep(600);
            //         Console.Write('.');
            //         Console.Beep(freq, 150);
            //         freq += 150;
            //     }
            //     Console.Beep(650, 750);
            //     Console.Clear();
            //     Game game = new Game();
            //     bool playing = true;
            //     while (playing)
            //     {
            //         Console.Write("What is your guess: ");
            //         string guess = Console.ReadLine();
            //         if (int.TryParse(guess, out int intGuess))
            //         // The console needs to read a String, but we need to pass it a Number, so we must convert it first
            //         // If TryParse successfully parses the String, it will return IntGuess, which is the parsed value
            //         {
            //             playing = !game.Guess(intGuess);
            //         }
            //         else
            //         {
            //             Console.WriteLine("Not that sharpest tool are ya?");
            //         }
            //     }
            //     Console.WriteLine("GG Bruvs");
            //     Console.WriteLine("Shall we play again...? (Y?N)");
            //     choice = Console.ReadKey().KeyChar;
            //     Console.WriteLine("");
            //     if (choice == 'y')
            //     {
            //         Console.WriteLine("Lets Play!");
            //     }
            //     else if (choice == 'n')
            //     {
            //         Console.WriteLine("Bye Loser!");
            //         running = false;
            //     }
            //     else
            //     {
            //         Console.WriteLine("Your Stupidity is upsetting, I'm done");
            //         running = false;
            //     }
            // }

            // SECTION Login
            // Console.WriteLine("Please create a Username for your account");
            // string username = Console.ReadLine();
            // Console.WriteLine("Please create a Password for your account");
            // string password = Console.ReadLine();
            // User user = new User(username, password);
            // Dictionary<string, string> users = new Dictionary<string, string>();
            // users.Add(user.Name, user.Pass);
            // string pass = "";
            // for (int i = 0; i < password.Length; i++)
            // {
            //     pass += "*";
            // }
            // // List<string> userlist = new List<string>()
            // // {
            // //     Users.forEach(u => userList += u.username)
            // // };
            // Console.Clear();
            // Console.WriteLine($"Welcome {username}!  Your password {pass} was successfully created!");
            // Console.WriteLine("Please log in to continue...");
            // Console.Write("Username: ");
            // username = Console.ReadLine();
            // Console.Write("\nPassword: ");
            // password = Console.ReadLine();

            // if (users.ContainsKey(username) && users.ContainsKey(password))
            // {
            //     Console.WriteLine($"Welcome back {username}!");
            // }
            // else
            // {
            //     string error = "Invalid Username or Password!";
            //     for (int i = 0; i < error.Length; i++)
            //     {
            //         Console.Write(error[i]);
            //         Thread.Sleep(50);
            //     }
            //     Thread.Sleep(1500);
            //     Console.Clear();
            // }

            // Console.WriteLine($"Here is a list of all active Users:");
            // Console.WriteLine($@"Here is a list of all active Users:");



            // Console.WriteLine("Hello World!");
            // NOTE Console.log Equivalent

            // SECTION PRIMATIVE DATA TYPES
            //      STRING  <-- NOTE Must use "Double Quotes"
            //      CHAR  <-- NOTE Must use 'Single Quotes'
            //          string myFirstName = "Sam";
            //          char myMiddleInitial = 'W';
            //          string myLastName = "Limpic"
            //              SECTION Concatenation:
            //                  string myName = myFirstName + " " + myMiddleInitial + " " + myLastName
            //              SECTION Interpolation:
            //                  string myName = $"{myFirstName} {myMiddleInitial} {myLastName}"
            //                  string myName = ($"{0} {1} {2}", myFirstName, myMiddleInitial, myLastName) 
            //                      NOTE Alternate syntax
            //                  $@"..."  <-- Adds support for Line Breaks typed inside the String itself

            //      BOOLEAN <-- NOTE Basically unchanged
            //          bool isTrue

            //      NUMBER <-- NOTE Several number types
            //          int  <-- whole numbers between -2,147,483,648 and 2,147,483,647 <-- Cuz &$%# you that's why!
            //              int x = 8;  <-- Implied integer
            //              var x = 8;  <-- Explicit integer
            //          float  <-- decimals with up to 6-9 digits <-- Nice
            //              float y = 4.5;
            //              var y = 4.5f;  <--  the 'f' explicitly declares an implicit variable as "float"
            //                  double  <-- 'd'
            //          decimal  <-- decimals beyond 9 digits
            //              decimal z = 2.5
            //              var z = 2.5d;

            //      NULL / UNDEFINED  <-- NOTE There is no "Undefined"

            // SECTION COMPLEX DATA TYPES
            //      COLLECTIONS
            //          ARRAY  <-- NOTE Fixed length, properties must be set by index & can't be modified.  Gross.
            //              string[] names = new String[] { "Mark", "Jonesey", "Mick", "Harrison" }
            //                  NOTE Uses [] in the declaration and {} when defining the values
            //          LIST  <-- NOTE Works like a JS Array with alternate syntax
            //              List<string> names = newList<string>() { "Mark", "Jonesey", "Mick", "Harrison" }
            //                  NOTE List is the Method, <string> means "of type String", names is the variable
            //                  NOTE Is equivalent to "let names = ["Mark", "Jonesey", "Mick", "Harrison"] in JS
            //                  NOTE must import "System.Collections.Generic" in the System
            //                  names.Insert(0, "Justin");
            //                  names.Remove("Harrison");
            //          DICTIONARIES  <-- NOTE No regular objects in C#
            //              NOTE Takes in a Key / Value pair to build an object
            //              Dictionary<string, string> staffRoles new Dictionary<string, string>(){
            //                      { "Mark", "Instructor" }
            //                  };
            //                  staffRoles.Add("Justin", "TA");
            //              Dictionary<string, User> users = new Dictionary<string, User>(){
            //                  User mark = new User("Mark", 32)
            //                  }

            // SECTION Console Goodies
            //      GET INPUT
            //          Console.Clear();
            //          Console.WriteLine("Hello, what is your name?");
            //          string name = Console.ReadLine();  <-- Reads whatever you Write in the console
            //          Console.WriteLine($"Hello {name}")
        }
    }
}
