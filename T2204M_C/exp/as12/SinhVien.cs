using System;
namespace T2204M_C.exp.as12
{
	public class SinhVien
	{

        private int id;
        private string name;
        private string gender;
        private int age;
        private double toan;
        private double ly;
        private double hoa;
        private double tb;
        private string hocluc;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public double Toan { get => toan; set => toan = value; }
        public double Ly { get => ly; set => ly = value; }
        public double Hoa { get => hoa; set => hoa = value; }
        public double Tb { get => tb; set => tb = value; }
        public string Hocluc { get => hocluc; set => hocluc = value; }

        public SinhVien(int id, string name, string gender, int age, double toan, double ly, double hoa, double tb, string hocluc)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;
            this.tb = tb;
            this.hocluc = hocluc;
        }



        public SinhVien()
		{
		}
        



     
	}
}

