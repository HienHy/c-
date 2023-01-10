using System;
namespace T2204M_C.ss5
{
	public delegate void PrintString(String s);
	public class DemoDelegate
	{

		public void ShowMessage(String msg) {
			Console.WriteLine("show " + msg);
				}

		
		public static void Alert(String str)
		{
			Console.WriteLine("Alert" + str);
		}
			

	}
}

