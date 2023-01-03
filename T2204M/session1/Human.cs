using System;
namespace T2204M.session1
{
	public class Human
	{
		public string name;
		public int age;

		public void Eat()
		{
			Console.WriteLine("Eating..");
		}

		public void Run()
		{
			Console.WriteLine(this.name + " running..");
		}
	}
}

