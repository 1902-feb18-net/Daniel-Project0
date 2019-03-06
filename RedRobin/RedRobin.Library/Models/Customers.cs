using System;
using System.Text.RegularExpressions;

namespace RedRobin.Library.Models
{
    public class Customers
    {
        public int Id { get; set; }

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Full name must be provided.");
                }
                _name = value;
            }
        }

        private string _phone;

        public string Phone
        {
            get => _phone;
            set
            {
                var match = Regex.Match(value, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
                if (!match.Success)
                {
                    throw new ArgumentException("Phone number must be in the correct format");
                }
                _phone = value;
            }
        }
    }
}
