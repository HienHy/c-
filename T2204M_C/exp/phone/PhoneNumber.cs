using System;
namespace T2204M_C.ss3
{
	public class PhoneNumber
	{
        private String name;
        List<String> tel;

		public PhoneNumber()
		{
		}

        public PhoneNumber(string name, String tel)
        {
            this.name = name;
            this.tel = new List<String>();
			this.tel.Add(tel);
        }

        public string Name { get => name; set => name = value; }
        public List<string> Tel { get => tel; set => tel = value; }
    }
}

