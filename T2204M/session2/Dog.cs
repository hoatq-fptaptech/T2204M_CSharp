using System;
namespace T2204M.session2
{
	public class Dog : Animal, IAnimal, IDog
	{
		private double weight;
		private string color;

		public double Weight
		{
			get { return weight; }
			set { weight = value; }
		}

		public string Color
		{
			get => color;
			set => color = value;
		}

        public Dog():base(null)
		{

		}


        public Dog(string kind,double weight) :base(kind)
		{
			this.weight = weight;
		}

		public void Info()
		{
			Console.WriteLine(GetKind());
		}

        public sealed override void SetKind(string k)
        {
            base.SetKind(k);
        }
    }
}

