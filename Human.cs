using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
	internal class Human
	{
		public string Name;
		public string Surname;
		public byte Age;
		public string City;

        public Human(string name,string surname,byte age, string city)
        {
            Name= name;
			Surname= surname;
			Age= age;
			City= city;
        }
        public Human()
        {
            
        }

        public bool IsStudent()
		{
			if (Age >= 18 && Age <= 25)
			{
				return true;
			}
			return false;
		}
		public void CheckCity(string city1, string city2, string city3, string city4)
		{
			if(city1.Equals(city3))
			{
                Console.WriteLine("Eyni seherdedir");
            }
			if (city2.Equals(city4))
			{
				Console.WriteLine("Eyni seherdedir");
			}
			else
			{
                Console.WriteLine("Eyni seherde deyil");
            }
		}
		public void GetCount(Human[] humans)
		{
			bool[] check= new bool[humans.Length];
			
			for (int i = 0; i < humans.Length; i++)
			{
				if (!check[i]) 
				{
					int count = 0;
					for (int j = 0; j < humans.Length; j++)
					{
						if (humans[i].City.Equals(humans[j].City, StringComparison.OrdinalIgnoreCase))
						{
							count++;
							check[j] = true;

						}
					}
					Console.WriteLine($"{humans[i].City} : {count} ");
					count = 0;
				}
            }
		}
    }
}
