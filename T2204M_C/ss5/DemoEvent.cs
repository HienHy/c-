using System;
namespace T2204M_C.ss5
{
	public class DemoEvent
	{

		public event PrintString Click;

		public DemoEvent()
		{
			Click += DemoDelegate.Alert;
			Click += new DemoDelegate().ShowMessage;
		}


		public void ClickAction() => Click("Click here");

    }
}

