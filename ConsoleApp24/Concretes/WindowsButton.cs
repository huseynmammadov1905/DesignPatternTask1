using ConsoleApp24.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Concretes
{
	internal class WindowsButton : IButton
	{
		public WindowsButton()
		{
			 Console.WriteLine("Hello,I'm WindowsButton"); 
		}
		public void OnClick() => Console.WriteLine("I'm WindowsButton");
		

		public void Render()=> Console.WriteLine("I'm WindowsButton");


	}
}
