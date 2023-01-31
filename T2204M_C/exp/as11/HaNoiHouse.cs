using System;
using house.cm;
namespace house.hanoi
	
{
	public class HaNoiHouse:House
    {

		private String tenQuan;


        public HaNoiHouse()
		{
		}

        public HaNoiHouse(string soNha, string diaChi, string loaiNha,String tenQuan) : base(soNha, diaChi, loaiNha)
        {
            this.SoNha = soNha;
            this.DiaChi = diaChi;
            this.LoaiNha = loaiNha;
            this.tenQuan = tenQuan;
        }

        public string TenQuan { get => tenQuan; set => tenQuan = value; }

        public override void Display()
        {
            base.Display();
        }

        public override void Input()
        {
            base.Input();
        }
    }
}

