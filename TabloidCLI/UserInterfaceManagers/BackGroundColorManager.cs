using System;
using System.Collections.Generic;
using System.Text;
using TabloidCLI.Models;

namespace TabloidCLI.UserInterfaceManagers
{
    public class BackGroundColorManager : IUserInterfaceManager
    {
        private readonly IUserInterfaceManager _parentUI;
        private BackGroundColorRepository _BackGroundColorRepository;
        private string _connectionString;

        public BackGroundColorManager(IUserInterfaceManager parentUI, string connectionString)
        {
            _parentUI = parentUI;
            _BackGroundColorRepository = new BackGroundColorRepository(connectionString);
            _connectionString = connectionString;
        }

        public IUserInterfaceManager Execute()
        {
            Console.WriteLine("Choose background color");
            Console.WriteLine(" 1) DarkRed");
            Console.WriteLine(" 2) DarkMagenta");
            Console.WriteLine(" 3) DarkBlue");
            Console.WriteLine(" 4) DarkYellow");
            Console.WriteLine(" 5) Black");
            Console.WriteLine(" 0) Go Back");

            Console.Write("> ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    return this;
                case "2":
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.Clear();
                    return this;
                case "3":
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Clear();
                    return this;
                case "4":
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.Clear();
                    return this;
                case "5":
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    return this;
                case "0":
                    Console.Clear();
                    return _parentUI;
                default:
                    Console.WriteLine("Invalid Selection");
                    return this;
            }
        }
    }
}