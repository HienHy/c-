using System;
namespace T2204M_C.ss1
{
	public class Human
	{
		public string name;
        public int age;
        public String address;

        public Human()
        {
            Console.WriteLine("hello world");
        }

        public Human(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public void Eat()
		{
			Console.WriteLine("Eating.....!");
		}

        public void Eat(String msg)
        {
            Console.WriteLine("Eating.....!"+msg);
        }


        public void Run()
        {
            Console.WriteLine(this.name+ "Runing.....!");
        }
    }
}

