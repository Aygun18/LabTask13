using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
	internal class Insan
	{
        public string Name;
        public string Surname;
        public byte Age;
        public string Gender;
        
        public void GetInfo(string name,string surname,byte age,string gender)
        {
            Console.WriteLine($"{name} {surname} {age} {gender}");
        }

    }
}
