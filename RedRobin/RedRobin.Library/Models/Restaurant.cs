using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace RedRobin.Library.Models
{
    [JsonObject(Title = "Restaurant")]
    public class Restaurant
    {
 

        public int Id { get; set; }

        private string _location;

        public string Location
        {
            get => _location;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Location must be provided.");
                }
                _location = value;
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
