namespace Class
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Insan insan = new Insan();
			insan.GetInfo("Ali","Aliyev",25,"male");
			Human human=new Human();
			Human human1=new Human("Ali","Aliyev",23,"baku");
			Human human2 = new Human("Vali", "Aliyev", 29, "Sumqayit");
			Human human3 = new Human("Murad", "Aliyev", 17, "Baku");
			Human human4 = new Human("Samir", "Aliyev", 25, "Baku");
			Human human5 = new Human("Ali", "Aliyev", 23, "Baku");
			Human human6 = new Human("Vali", "Aliyev", 29, "Sumqayit");
			Human human7 = new Human("Murad", "Aliyev", 17, "Baku");
			Human human8 = new Human("Hemid", "Aliyev", 25, "Gence");
			Human human9 = new Human("Aylin", "Aliyeva", 25, "Baku");

			Human[] humans = {human1,human2,human3,human4,human5,human6,human7,human8,human9};

			Console.WriteLine(human1.IsStudent());
			Console.WriteLine(human2.IsStudent());
			Console.WriteLine(human3.IsStudent());
			Console.WriteLine(human4.IsStudent());

			human.CheckCity(human1.City,human2.City,human3.City,human4.City);

			human.GetCount(humans);
			
		}
	}
}