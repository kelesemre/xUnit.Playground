using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.ConsoleApp
{
    public class Names
    {
        public string NickName { get; set; }
        public string MakeFullName(string name, string surname)
        {
            return $"{name} {surname}";
        }
    }
}
