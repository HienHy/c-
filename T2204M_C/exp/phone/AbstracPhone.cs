
using System;
namespace T2204M_C.ss3
{
	public abstract class AbstracPhone
    {
       public abstract void InsertPhone(String name, String phone);
      public  abstract void RemovePhone(String name);

      public  abstract void UpdatePhone(String name, String oldPhone, String newPhone);


       public abstract PhoneNumber SearchPhone(String name);


      public  abstract void Sort();



    }
}

