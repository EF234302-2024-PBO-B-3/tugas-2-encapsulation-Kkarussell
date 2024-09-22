using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Encapsulation.Extra
{
    public class Extras
    {
        private string _username = "Unknwon";
        private string _email = "Unknown";
        private double _balance;
        private List<string> _ownedGames;

        public string Username
        {
            get { return _username; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _username = value;
                else
                    throw new ArgumentException("Username cannot be null or empty.");
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (IsValidEmail(value))
                    _email = value;
                else
                    throw new ArgumentException("Invalid email format.");
            }
        }

        public double Balance => _balance;

        public List<string> OwnedGames => _ownedGames;

        public Extra(string username, string email, double balance)
        {
            Username = username;
            Email = email;
            _balance = balance >= 0 ? balance : 0.0;
            _ownedGames = new List<string>();
        }

        public void Deposit(double amount)
        {
            if (amount >= 0)
            {
                _balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount >= 0 && _balance >= amount)
            {
                _balance -= amount;
            }
        }

        public void AddGame(string game)
        {
            if (!_ownedGames.Contains(game))
            {
                _ownedGames.Add(game);
            }
            else
            {
                Console.WriteLine($"Game '{game}' is already owned.");
            }
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Balance: ${Balance}");
            Console.WriteLine("Owned Games: " + (OwnedGames.Count > 0 ? string.Join(", ", OwnedGames) : "No games owned."));
        }

        private bool IsValidEmail(string email)
        {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}
