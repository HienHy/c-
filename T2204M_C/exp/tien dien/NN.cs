using System;
namespace T2204M_C.exp.tiendien
{
	public class NN :KH
	{
        public String qt;
        public NN(int customerId, string name, string date, string dt, double sl,String qt) : base(customerId, name, date, dt, sl)
        {
            this.qt = qt;
        }

        public string Qt { get => qt; set => qt = value; }

        public override double TT()
		{
            double tt = 0;
            tt = this.Sl * 2000;
            return tt;
        }
		public NN()
		{
		}

     
    }
}

