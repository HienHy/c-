using System;
namespace T2204M_C.exp.tiendien
{
	public abstract class KH
	{
        private int customerId;
        private String name;
        private String date;
        private String dt;
        private double sl;

        public int CustomerId { get => customerId; set => customerId = value; }
        public string Name { get => name; set => name = value; }
        public string Date { get => date; set => date = value; }
        public string Dt { get => dt; set => dt = value; }
        public double Sl { get => sl; set => sl = value; }

        public KH()
		{
		}

        public  KH(int customerId, string name, string date, string dt, double sl)
        {
            this.customerId = customerId;
            this.name = name;
            this.date = date;
            this.dt = dt;
            this.sl = sl;
        }
        public abstract double TT();
        

        
    }
}

