using System;
namespace T2204M_C.exp.tiendien
{
	public class VN:KH
	{


        public override double TT()
        {
            double tt = 0;
            if (this.Sl <= 50)
            {
                tt = (this.Sl * 1000);
            }

            if (this.Sl > 50 && this.Sl <= 100)
            {
                tt = (this.Sl - 50) * 1200 + (50 * 1000);
            }

            if (this.Sl > 100 && this.Sl <= 200)
            {
                tt = (this.Sl - 100) * 1500 + (50 * 1000) + (50 * 1200);
            }

            if (this.Sl > 200)
            {

                tt = (this.Sl - 200) * 2000 + (50 * 1000) + (50 * 1200) + (100 * 1500);

            }
            return tt;

        }
        public VN()
		{
		}

        public VN(int customerId, string name, string date, string dt, double sl) : base(customerId, name, date, dt, sl)
        {
        }
    }
}

