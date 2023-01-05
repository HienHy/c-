using System;
namespace T2204M_C.ss1
{
	public class Fraction

	{
		int tuSo;
		int mauSo;

		public Fraction(){}

        public Fraction(int tuSo, int mauSo)
        {
            this.TuSo = tuSo;
            this.MauSo = mauSo;
        }

        public int TuSo { get => tuSo; set => tuSo = value; }
        public int MauSo { get => mauSo; set => mauSo = value; }
        public void printPhanSo()
        {
            Console.WriteLine("Phan so = " + tuSo + "/" +mauSo );

        }

       
    }
}

