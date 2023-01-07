using System;
using System.Xml.Linq;

namespace T2204M_C.ss3
{
	public class PhoneBook:AbstracPhone
	{
        List<PhoneNumber> pl = new List<PhoneNumber>();



		public PhoneBook()
		{
		}

        public List<PhoneNumber> Pl { get => pl; set => pl = value; }

        public override void InsertPhone(string name, string phone)
        {


            foreach(PhoneNumber p in Pl)
            {


                if (p.Name.Equals(name))
                {
                    foreach(String s in p.Tel)
                    {
                        if (s.Equals(phone))
                        {
                            return;
                        }
                    }
                    p.Tel.Add(phone);
                    return;

                }
            }
            PhoneNumber pn = new PhoneNumber(name, phone);
            Pl.Add(pn);
            throw new NotImplementedException();
        }





        public override void RemovePhone(string name)
        {
            foreach(PhoneNumber p in Pl)
            {
                if (p.Name.Equals(name))
                {
                    Pl.Remove(p);
                    return;
                }
            }


            throw new NotImplementedException();
        }

        public override PhoneNumber SearchPhone(string name)
        {

            foreach (PhoneNumber p in Pl)
            {
                if (p.Name.Equals(name))
                {
                    return p;
                }

            }

            throw new NotImplementedException();

        }

        public override void Sort()
        {

       

                    throw new NotImplementedException();
        }

        public override void UpdatePhone(string name, string oldPhone, string newPhone)
        {

            foreach (PhoneNumber p in Pl)
            {
                if (p.Name.Equals(name))
                {
                    p.Tel.Remove(oldPhone);
                    p.Tel.Add(newPhone);
                    return;

                }


            }




            throw new NotImplementedException();
        }






    }


}

