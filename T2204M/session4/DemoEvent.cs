using System;
namespace T2204M.session4
{
	public class Button
	{
		public event PrintString Action;

		public Button(PrintString functionName)
		{
			Action += functionName;
		}

		public void ClickAction()
		{
            Action("Click here");
		}
	}
}

