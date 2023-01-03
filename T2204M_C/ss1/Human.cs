using System;
namespace T2204M_C.ss1
{
	public class Human
	{
		public string name;
        public int age;
		public void Eat()
		{
			Console.WriteLine("Eating.....!");
		}


        public void Run()
        {
            Console.WriteLine(this.name+ "Runing.....!");
        }
    }
}

