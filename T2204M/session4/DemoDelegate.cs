using System;
namespace T2204M.session4
{
	public delegate void PrintString(string s);

	public class DemoDelegate
	{
		public void ShowMessage(string msg)
		{
			Console.WriteLine("Show Info: " + msg);
		}

		public static void Alert(string str)
		{
			Console.WriteLine("Alert: " + str);
		}
	}
}

