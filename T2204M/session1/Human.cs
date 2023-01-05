using System;
namespace T2204M.session1
{
	public class Human
	{
		public string name;
		public int age;

		private string address;

		public Human()
		{
			Console.WriteLine("Human: Hello world");
		}

		public Human(string name,int age, string address)
		{
			this.name = name;
			this.address = address;
			this.age = age;
		}

		~Human() // destructor
		{
			
		}

		public void Eat()
		{
			Console.WriteLine("Eating..");
		}

		public string Eat(string msg)
		{
			return "Human: "+ msg;
		}

		public void Run()
		{
			Console.WriteLine(this.name + " running..");
		}
	}
}

