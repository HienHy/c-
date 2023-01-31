using System;
namespace house.cm
{
	public class House:IHouse
	{

        private String soNha;

        private String diaChi;

        private String loaiNha;


        public House()
		{
		}

        public House(string soNha, string diaChi, string loaiNha)
        {
            this.soNha = soNha;
            this.diaChi = diaChi;
            this.loaiNha = loaiNha;
        }

        public string SoNha { get => soNha; set => soNha = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string LoaiNha { get => loaiNha; set => loaiNha = value; }

        public virtual void Display()
        {
           
            throw new NotImplementedException();
        }

        public virtual void Input()
        {
            throw new NotImplementedException();
        }
    }
}

