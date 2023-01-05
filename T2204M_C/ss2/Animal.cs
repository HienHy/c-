using System;
namespace T2204M_C.ss2
{
	public class Animal
	{
		private String kind;


		public virtual void SetKind(String k)
		{
			kind = k;
		}

		public String GetKind()
		{
			return kind;
		}




		public Animal()
		{
		}

		public Animal(string kind)
		{
			this.kind = kind;
		}
	}
}

