using System;
namespace T2204M_C.ss2
{
	public class Dog : Animal,IAnimal
	{
        private double weight;

        private String color;

        

        public double Weight { get => weight; set => weight = value; }
        public string Color { get => color; set => color = value; }

        public Dog(String kind,double weight):base(kind)
        {
            this.weight = weight;
        }

        public override void SetKind(string k)
        {
            base.SetKind(k);
        }


        public void Info()
        {
            Console.WriteLine(GetKind());
        }
        public Dog():base(null)
		{
		}
	}
}

