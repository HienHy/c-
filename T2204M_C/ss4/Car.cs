using System;
namespace T2204M_C.ss4
{
	public class Car
	{


		public List<String> machines = new List<string>();

		public String Brand { get; set; }

		public String Type { get; set; }

		public double Price { get; set; }


		public String this[int index]
		{
			get => machines[index];
            set => machines[index] = value;

        }



        public Car()
		{
			machines.Add("bao ve cang truoc");
            machines.Add("den tro sang");



        }


    }
}

