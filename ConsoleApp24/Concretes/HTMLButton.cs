using ConsoleApp24.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Concretes
{
	internal class HTMLButton : IButton
	{
		public HTMLButton() { Console.WriteLine("Hello,I'm HTML"); }
		public void OnClick() => Console.WriteLine("I'm HTML Button");


		public void Render() => Console.WriteLine("I'm HTML Button");
		
	}
}
