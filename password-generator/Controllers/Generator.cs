using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploAPI.Controllers
{
    public class Generator
    {
        Random rnd = new Random();
        const string upChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string chars = "abcdefghijklmnopqrstuvwxyz";
        const string specialChars = "!@#$%&*-+.*";

        public List<string> EasyPassword()
        {
            return new List<String> { new string(Enumerable.Repeat(chars, 4)
                .Select(s => s[rnd.Next(s.Length)]).ToArray()) };
        }

        public List<string> MidiumPassword()
        {
            return new List<String> {new string(Enumerable.Repeat(chars, 4)
                .Select(s => s[rnd.Next(s.Length)]).ToArray()) + rnd.Next(100, 999).ToString() };
        }

        public List<string> HardPassword()
        {
            return new List<String> {new string(Enumerable.Repeat(upChars, 2)
                .Select(s => s[rnd.Next(s.Length)]).ToArray()) + new string((Enumerable.Repeat(chars, 1)
                .Select(s => s[rnd.Next(s.Length)]).ToArray())) + new string(Enumerable.Repeat(specialChars, 1)
                .Select(s => s[rnd.Next(s.Length)]).ToArray()) + new string(Enumerable.Repeat(chars, 2)
                .Select(s => s[rnd.Next(s.Length)]).ToArray()) + new string(Enumerable.Repeat(specialChars, 1)
                .Select(s => s[rnd.Next(s.Length)]).ToArray()) + new string(Enumerable.Repeat(upChars, 2)
                .Select(s => s[rnd.Next(s.Length)]).ToArray())};
        }

        public List<string> OnlyNumberPassword()
        {
            return new List<String> { rnd.Next(10000000, 99999999).ToString() };
        }
    }
}
